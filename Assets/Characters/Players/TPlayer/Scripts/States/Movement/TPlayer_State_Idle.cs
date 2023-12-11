using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPlayer_State_Idle : IPlayerState
{
    private TPlayer player;
    private PlayerPhysics physics;
    private string startAnimation;

    private Vector2 xAxis;
    private Vector2 zAxis;
    public TPlayer_State_Idle(TPlayer tPlayer, string _startAnimation = "Idle")
    {
        player = tPlayer;
        physics = player.Physics;
        startAnimation = _startAnimation;
    }

    public void Enter()
    {
        //physics.Velocity = Vector3.zero;
    }

    public void Physics()
    {
        physics.MoveInDirection(xAxis, zAxis);
        physics.ApplyGravity();
        physics.Move();
    }
    public void Process()
    {
        if (xAxis != Vector2.zero || zAxis != Vector2.zero) 
        {
            player.SwitchState(new TPlayer_State_Walking(player));
        }
    }
    public void OnInput()
    {
        xAxis = new Vector2(Input.AxisLeft, Input.AxisRight);
        zAxis = new Vector2(Input.AxisDown, Input.AxisUp);

        if (Input.JumpButton.pressed)
        {
            physics.Jump();
        }
        if (Input.ActionButton.pressed)
        {
            player.SwitchState(new TPlayer_State_Attack_G_0(player));
        }
    }

    public void Exit()
    { }
}
