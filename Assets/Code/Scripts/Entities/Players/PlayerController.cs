using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerState : IEntityState
{
    public void HandleInput();
}
public class PlayerController : Entity
{
    public IPlayerState PlayerState;
    //[HideInInspector]
    public PlayerPhysicsController PlayerPhysics;

    protected virtual void Start()
    {
        PlayerPhysics = GetComponent<PlayerPhysicsController>();
    }

    public void Update()
    {
        PlayerState.HandleInput();
    }

    public void FixedUpdate()
    {
        PlayerState.HandleBehavior();
        PlayerState.HandlePhysics();
    }

    public virtual void SwitchState(IPlayerState newPlayerState)
    {
        if (newPlayerState.Equals(null))
            return;
        PlayerState.OnExit();
        PlayerState = newPlayerState;
        PlayerState.OnEnter();
    }
}
