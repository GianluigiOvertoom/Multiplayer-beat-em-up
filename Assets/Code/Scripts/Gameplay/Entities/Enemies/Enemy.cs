using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Enemy : Entity
{
    public IEntityState EnemyState;
    public EnemyPhysics Physics;

    protected virtual void Start()
    {
        Physics = GetComponent<EnemyPhysics>();
    }

    protected virtual void Update()
    {
        EnemyState.Physics();
        EnemyState.Process();
    }

    public void SwitchState(IEntityState newEnemyState)
    {
        if (newEnemyState.Equals(null))
            return;
        EnemyState.Exit();
        EnemyState = newEnemyState;
        EnemyState.Enter();
    }
}
