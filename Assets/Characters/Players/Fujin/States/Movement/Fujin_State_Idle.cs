using System.Collections;
using System.Collections.Generic;
using Unity.Services.Lobbies.Models;
using UnityEngine;

public class Fujin_State_Idle : IPlayerState
{
    private Fujin player;
    private PlayerPhysicsController physics;
    
    private Vector2 xAxis;
    private Vector2 zAxis;
    public Fujin_State_Idle(Fujin fujin)
    {
        player = fujin;
        physics = fujin.PlayerPhysics;
    }
    public void OnEnter()
    {
        
    }
    public void HandleInput() 
    {
        if (Input.JumpButton.pressed)
        {
            Debug.Log("Iniate jump");
        }
    }
    public void HandleBehavior() { }
    public void HandlePhysics() 
    {
        Vector2 xAxis = new Vector2(Input.AxisLeft, Input.AxisRight);
        Vector2 zAxis = new Vector2(Input.AxisDown, Input.AxisUp);
        physics.MovementDirection(xAxis, zAxis);
        if (physics.Velocity.x != 0 || physics.Velocity.z != 0)
            player.SwitchState(new Fujin_State_Running(player));
        physics.Move();
    }
    public void OnExit() { }
}
