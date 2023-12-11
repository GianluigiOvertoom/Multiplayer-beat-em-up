using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPlayer_State_Walking : IPlayerState
{
    private TPlayer player;
    private PlayerPhysics physics;

    private Vector2 xAxis;
    private Vector2 zAxis;
    public TPlayer_State_Walking(TPlayer tPlayer)
    {
        player = tPlayer;
        physics = player.Physics;
    }

    public void Enter()
    { }

    public void Physics()
    {
        physics.MoveInDirection(xAxis, zAxis);
        physics.ApplyGravity();
        physics.Move();       
    }
    public void Process()
    {
        if (xAxis == Vector2.zero && zAxis == Vector2.zero)
        {
            player.SwitchState(new TPlayer_State_Idle(player));
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
