using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPhysicsData
{
    public static float VelocityCap = 15f;

    public static float WalkSpeed = 5f;
    public static float RunSpeed = WalkSpeed * 2f;

    public static float MaxJumpHeight = 5f;
    public static float MinJumpHeight = 0.75f;
    public static float JumpSpeed = 0.25f;
    public static float CoyoteTime = 1f;
    public static float AirTime = 0.1f;
}
