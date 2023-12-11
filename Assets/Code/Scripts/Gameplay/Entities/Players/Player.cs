using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.Timeline;

public interface IPlayerState : IEntityState
{
    void OnInput();
}

public class Player : Entity
{
    public IPlayerState PlayerState;
    public PlayerPhysics Physics;
    private float runTime = 0.2f;
    private float runTimer;
    public bool IsRunning;

    private Vector3 debugAttackSize;
    private Vector3 debugAttackOffset;

    protected virtual void Start()
    {
        Physics = GetComponent<PlayerPhysics>();
        IsRunning = false;
    }

    protected virtual void Update()
    {
        PlayerState.Physics();
        PlayerState.Process();
        PlayerState.OnInput();
    }

    public void SetRunTime()
    {
        runTimer = runTime;
    }

    public void SwitchState(IPlayerState newPlayerState)
    {
        if (newPlayerState.Equals(null))
            return;
        PlayerState.Exit();
        PlayerState = newPlayerState;
        PlayerState.Enter();
    }
}
