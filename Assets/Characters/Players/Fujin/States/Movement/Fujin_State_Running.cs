using System.Collections;
using System.Collections.Generic;
using Unity.Services.Lobbies.Models;
using UnityEngine;

public class Fujin_State_Running : IPlayerState
{
    private Fujin player;
    private PlayerPhysicsController physics;

    private Vector2 xAxis;
    private Vector2 zAxis;
    public Fujin_State_Running(Fujin fujin)
    {
        player = fujin;
        physics = player.PlayerPhysics;
    }
    public void OnEnter() 
    { }
    public void HandleInput()
    { }
    public void HandleBehavior() { }
    public void HandlePhysics() 
    {
        Vector2 xAxis = new Vector2(Input.AxisLeft, Input.AxisRight);
        Vector2 zAxis = new Vector2(Input.AxisDown, Input.AxisUp);
        physics.MovementDirection(xAxis, zAxis);
        if (physics.CheckIfAxisPressed(xAxis) == 0 && physics.CheckIfAxisPressed(zAxis) == 0)
        {
            if (physics.CheckIfAxisPressed(xAxis) == 0)
                player.SwitchState(new Fujin_State_Idle(player));
        }

        physics.Move();
    }
    public void OnExit() { }
}
