using UnityEngine;

public enum OneWayWallEntrance
{
    left,
    right
}

[RequireComponent(typeof(BoxCollider))]
public class OneWayBoxCollider : MonoBehaviour
{
    [SerializeField] private Vector3 entryDirection = Vector3.right;
    [SerializeField] private LayerMask collisionMask;
    [SerializeField] private OneWayWallEntrance entrance;

    private bool localDirection = true;
    private float triggerScale = 2f;
    private new BoxCollider collider = null;
    private BoxCollider collisionCheckTrigger = null;
    [SerializeField] private Collider[] colliders;

    private void Awake()
    {
        collider = GetComponent<BoxCollider>();
        collider.isTrigger = false;

        collisionCheckTrigger = gameObject.AddComponent<BoxCollider>();
        collisionCheckTrigger.size = (collider.size * triggerScale);
        collisionCheckTrigger.center = collider.center;
        collisionCheckTrigger.isTrigger = true;
    }
    private void FixedUpdate()
    {
        colliders = Physics.OverlapBox((transform.position + collider.center), (transform.localScale + collider.size), transform.rotation, collisionMask);

        if (colliders.Length != 0)
        {
            for (int i = 0; i < colliders.Length; i++)
                CheckTrigger(colliders[i]);
        }
    }
    private Vector3 GetDirection()
    {
        if (localDirection)
            return transform.TransformDirection(entryDirection.normalized);
        else
            return entryDirection;
    }
    private void CheckTrigger(Collider other)
    {
        if (other.GetType() != typeof(CharacterController))
            return;

        if (Physics.ComputePenetration(
            collisionCheckTrigger, transform.position, transform.rotation,
            other, other.transform.position, transform.rotation,
            out Vector3 collisionDirection, out float penetrationDepth
            ))
        {
            //Checks if collision is from the oppisite direction
            float dot = Vector3.Dot(GetDirection(), collisionDirection);
            //Deny passage if true
            if (dot < 0 && (penetrationDepth <= 0.4f))
            {
                Physics.IgnoreCollision(collider, other, false);
            }
            else
            {
                Physics.IgnoreCollision(collider, other, true);
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, GetDirection());

        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, -GetDirection());
    }
}
