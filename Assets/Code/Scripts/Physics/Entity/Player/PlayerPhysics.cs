using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPhysics : MonoBehaviour
{
    [HideInInspector] public CharacterController Controller;
    public LayerMask TargetMask;
    public Vector3 Velocity;
    public bool IsRunning;
    public bool IsGrounded;
    public bool WasGrounded;
    public float FaceDirection;
    public bool FreezeFaceDirection;
    public float Acceleration;

    private float walkSpeed = PlayerPhysicsData.WalkSpeed;
    private float runSpeed = PlayerPhysicsData.RunSpeed;
    private float minJumpHeight = PlayerPhysicsData.MinJumpHeight;
    private float maxJumpHeight = PlayerPhysicsData.MaxJumpHeight;
    private float jumpSpeed = PlayerPhysicsData.JumpSpeed;
    private float airTime = PlayerPhysicsData.AirTime;
    private float dropSpeed = PlayerPhysicsData.DropSpeed;
    private float coyoteTime = PlayerPhysicsData.CoyoteTime;
    private float jumpBuffer = PlayerPhysicsData.JumpBuffer;
    private float gravityMultiplier = PlayerPhysicsData.GravityMultiplier;
    private float velocityCap = PlayerPhysicsData.VelocityCap;

    private SpriteRenderer spriteRenderer;
    private float gravityAmount;
    private float maxJumpVelocity;
    private float minJumpVelocity;
    private Vector2 InputValue;
    private float velocityXSmoothing;

    private void Start()
    {
        Controller = GetComponent<CharacterController>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        SetGravityData();

        IsRunning = false;
        IsGrounded = false;
        WasGrounded = false;
        FaceDirection = 1f;
        FreezeFaceDirection = false;
        Acceleration = 0.1f;
    }

    public void Move()
    {
        Controller.Move(Velocity * Time.deltaTime);
        if (!Controller.isGrounded && IsGrounded)
        {
            WasGrounded = true;
        }
        else
        {
            WasGrounded = false;
        }
        IsGrounded = Controller.isGrounded;
        SetFaceDirection();
    }

    public void SetGravityData()
    {
        gravityAmount = -(2 * maxJumpHeight) / Mathf.Pow(jumpSpeed, 2);
        maxJumpVelocity = Mathf.Abs(gravityAmount) * jumpSpeed;
        minJumpVelocity = Mathf.Sqrt(2 * Mathf.Abs(gravityAmount) * minJumpHeight);
    }

    public void ApplyGravity()
    {
        Velocity.y += (gravityAmount * gravityMultiplier) * Time.deltaTime;
        if (Velocity.y < 0)
        {
            if (IsGrounded)
            {
                Velocity.y = -0.5f;
            }
            Velocity.y = Velocity.y * dropSpeed;
            Velocity.y = Mathf.Clamp(Velocity.y, -PlayerPhysicsData.VelocityCap, PlayerPhysicsData.VelocityCap);
        }
    }

    public void SetFaceDirection()
    {
        if (!FreezeFaceDirection)
        {
            float currentDirection = Mathf.Round(Velocity.x);
            if (currentDirection != 0)
            {
                FaceDirection = currentDirection;
                FaceDirection = Mathf.Clamp(FaceDirection, -1, 1);
            }
        }
        spriteRenderer.flipX = FaceDirection == 1 ? false : true;
    }

    public void MoveInDirection(Vector2 xAxis, Vector2 zAxis)
    {
        if (xAxis != Vector2.zero)
        {
            if (xAxis.x != 0f)
            {
                InputValue.x = -1f;
            }
            if (xAxis.y != 0f)
            {
                InputValue.x = 1f;
            }
        }
        else
        {
            InputValue.x = 0f;
        }
        if (zAxis != Vector2.zero)
        {
            if (zAxis.x != 0f)
            {
                InputValue.y = -1f;
            }
            if (zAxis.y != 0f)
            {
                InputValue.y = 1f;
            } 
        }
        else
        {
            InputValue.y = 0f;
        }
        float targetmoveAmountX = InputValue.x * (IsRunning ? runSpeed : walkSpeed);
        float targetmoveAmountZ = InputValue.y * (IsRunning ? runSpeed : walkSpeed);
        Velocity.x = Mathf.SmoothDamp(Velocity.x, targetmoveAmountX, ref velocityXSmoothing, Acceleration);
        Velocity.z = targetmoveAmountZ;
    }

    public void Jump()
    {
        Velocity.y = maxJumpVelocity;
    }

    public void StopJump()
    {
        if (Velocity.y > minJumpVelocity)
        {
            Velocity.y = minJumpVelocity;
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
                if(parentName == this.gameObject.name)
                {
                    Gizmos.DrawWireCube(transform.position + (new Vector3(hitBox.Offset.x * FaceDirection, hitBox.Offset.y)),
                    hitBox.Size * 2f);
                }
            }
        }
    }
}
