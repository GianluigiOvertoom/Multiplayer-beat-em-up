using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class OneWayCollider : MonoBehaviour
{
    [SerializeField] private Vector3 entryDirection = Vector3.up;
    [SerializeField] private bool localDirection = false;
    [SerializeField, Range(1f, 2f)] private float triggerScale = 1.25f;
    [SerializeField] private float skinWidth;
    private new BoxCollider collider = null;

    private BoxCollider collisionCheckTrigger = null;

    private void Awake()
    {
        collider = GetComponent<BoxCollider>();
        collider.isTrigger = false;
        skinWidth = transform.localScale.x / 2f;

        collisionCheckTrigger = gameObject.AddComponent<BoxCollider>();
        collisionCheckTrigger.size = collider.size * triggerScale;
        collisionCheckTrigger.center = collider.center;
        collisionCheckTrigger.isTrigger = true;
    }

    private void OnTriggerStay(Collider other)
    {
        if (Physics.ComputePenetration(
            collisionCheckTrigger, transform.position, transform.rotation,
            other, other.transform.position, other.transform.rotation,
            out Vector3 collisionDirection, out float penetrationDepth
            ))
        {
            Vector3 direction;
            if (localDirection)
            {
                direction = transform.TransformDirection(entryDirection.normalized);
            }
            else
            {
                direction = entryDirection;
            }
            float dot = Vector3.Dot(entryDirection, collisionDirection);
            //Allow passing, if it's the oppisite direction 
            if (dot < 0 && penetrationDepth <= skinWidth)
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
        Vector3 direction;
        if (localDirection)
        {
            direction = transform.TransformDirection(entryDirection.normalized);
        }
        else 
        {
            direction = entryDirection;
        }

        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, entryDirection);

        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, -entryDirection);
    }
}
