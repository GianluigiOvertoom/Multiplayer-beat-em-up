using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPhysics : MonoBehaviour
{
    [HideInInspector] public CharacterController Controller;
    public LayerMask TargetMask;
    public Vector3 Velocity;
    public float FaceDirection;
    public bool FreezeFaceDirection;
    public GameObject Target;

    private SpriteRenderer spriteRenderer;
    [SerializeField] private float moveSpeed = 3f;

    private void Start()
    {
        Controller = GetComponent<CharacterController>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        FaceDirection = 1f;
        FreezeFaceDirection = false;
    }
    public void Move()
    {
        Controller.Move(Velocity * Time.deltaTime);
        SetFaceDirection();
    }
    public void SetFaceDirection()
    {
        if (!FreezeFaceDirection)
        {
            float currentDirection = Mathf.Round(transform.position.x - Target.transform.position.x);
            if (currentDirection != 0)
            {
                FaceDirection = -currentDirection;
                FaceDirection = Mathf.Clamp(FaceDirection, -1, 1);
            }
        }
        spriteRenderer.flipX = FaceDirection == 1 ? false : true;
    }
    public void MoveFromTargetXZ()
    {
        Vector3 offset = Target.transform.position - transform.position;
        if (offset.magnitude > .1f)
        {
            offset = -offset.normalized * moveSpeed;
            Velocity = new Vector3(offset.x, Velocity.y, offset.z);
        }
    }
    public void MoveFromTargetXYZ()
    {
        Vector3 offset = Target.transform.position - transform.position;
        if (offset.magnitude > .1f)
        {
            offset = -offset.normalized * moveSpeed;
            Velocity = offset;
        }
    }
    public void MoveTowardsTargetXZ()
    {
        Vector3 offset = Target.transform.position - transform.position;
        if (offset.magnitude > .1f)
        {
            offset = offset.normalized * moveSpeed;
            Velocity = new Vector3(offset.x, Velocity.y, offset.z);
        }
    }
    public void MoveTowardsTargetXYZ()
    {
        Vector3 offset = Target.transform.position - transform.position;
        if (offset.magnitude > .1f)
        {
            offset = offset.normalized * moveSpeed;
            Velocity = offset;
        }
    }
    private void OnDrawGizmos()
    {
        if (HitBoxes.HitBoxList.Count > 0)
        {
            foreach (HitBox hitBox in HitBoxes.HitBoxList)
            {
                Gizmos.color = hitBox.Color;
                string parentName = hitBox.Parent.name;
                if (parentName == this.gameObject.name)
                {
                    Gizmos.DrawWireCube(transform.position + (new Vector3(hitBox.Offset.x * FaceDirection, hitBox.Offset.y)),
                    hitBox.Size * 2f);
                }
            }
        }
    }
}
