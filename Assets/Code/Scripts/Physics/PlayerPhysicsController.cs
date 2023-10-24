using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class PlayerPhysicsController : PhysicsController
{
    public float Gravity = 1f;
    public float Friction = 0f;
    public bool UseGravity = true;
    public bool IsRunning = false;

    private readonly float minJumpHeight = PlayerPhysicsData.MinJumpHeight;
    private readonly float maxJumpHeight = PlayerPhysicsData.MaxJumpHeight;
    private readonly float jumpSpeed = PlayerPhysicsData.JumpSpeed;
    private readonly float velocityCap = PlayerPhysicsData.VelocityCap;
    private readonly int coyoteTime = (int)PlayerPhysicsData.CoyoteTime * 100;
    private readonly float airTime = PlayerPhysicsData.AirTime;

    private float airTimer = 0f;
    private float velocityXSmoothing;
    private float gravityAmount;
    private float maxJumpVelocity;
    private float minJumpVelocity;

    public override void Start()
    {
        base.Start();
        gravityAmount = -(2 * maxJumpHeight) / Mathf.Pow(jumpSpeed, 2);
        maxJumpVelocity = Mathf.Abs(gravityAmount) * jumpSpeed;
        minJumpVelocity = Mathf.Sqrt(2 * Mathf.Abs(gravityAmount) * minJumpHeight);
    }

    public override void Move()
    {
        if (UseGravity)
            ApplyGravity();
        base.Move();
    }
    public void Jumping(float amount) => Velocity.y = (maxJumpVelocity * amount);
    public void StopJump()
    {
        if (Velocity.y > minJumpVelocity)
            Velocity.y = minJumpVelocity;
    }
    public void IniateJumpHover()
    {
        airTimer = airTime;
    }
    public async void InitiateCoyoteTime(PlayerController player, string jumpingState, IPlayerState fallingState)
    {
        await Task.Delay(coyoteTime);
        if (!Controller.isGrounded && player.PlayerState.ToString() != jumpingState)
            player.SwitchState(fallingState);
    }
    private void ApplyGravity()
    {
        Velocity.y += (gravityAmount * Gravity) * Time.deltaTime;
        Velocity.y = Mathf.Clamp(Velocity.y, -velocityCap, velocityCap);
        if (airTimer >= 0)
        {
            Velocity.y = 0;
            airTimer -= Time.deltaTime;
        }
    }
    public void MovementDirection(Vector2 xAxis, Vector2 zAxis)
    {
        float directionX = MovementAxis(xAxis);
        float directionZ = MovementAxis(zAxis);

        float targetmoveAmountX = directionX * ((IsRunning) ? PlayerPhysicsData.RunSpeed : PlayerPhysicsData.WalkSpeed);
        float targetmoveAmountZ = directionZ * (PlayerPhysicsData.WalkSpeed * 1.5f);

        Velocity.x = Mathf.SmoothDamp(Velocity.x, targetmoveAmountX, ref velocityXSmoothing, Friction);
        Velocity.z = Mathf.SmoothDamp(Velocity.z, targetmoveAmountZ, ref velocityXSmoothing, Friction);
    }
    private float MovementAxis(Vector2 input)
    {
        if (input != Vector2.zero)
        {
            if (input.x != 0)
                return -1;
            else
                return 1;
        }
        else
            return 0;
    }
    public float CheckIfAxisPressed(Vector2 Axis)
    {
        return MovementAxis(Axis);
    }
}
