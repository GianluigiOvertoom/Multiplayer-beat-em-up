using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPhysicsData
{
    public static float WalkSpeed = 5f;
    public static float RunSpeed = WalkSpeed * 2f;
    public static float Acceleration;

    public static float MaxJumpHeight = 3f;
    public static float MinJumpHeight = 1f;
    public static float JumpSpeed = 0.5f;
    public static float AirTime = 0.1f;
    public static float DropSpeed = 1f;
    public static float CoyoteTime = 0.2f;
    public static float JumpBuffer = 0.2f;
    public static float GravityMultiplier = 1f;

    public static float VelocityCap = 15f;
}
