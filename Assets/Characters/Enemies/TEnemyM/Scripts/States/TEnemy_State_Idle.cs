using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class TEnemy_State_Idle : IEntityState
{
    private TEnemyM enemy;
    private EnemyPhysics physics;
    private float timer;

    public TEnemy_State_Idle(TEnemyM tEnemy, float _timer = 1.5f)
    {
        enemy = tEnemy;
        physics = enemy.Physics;
        timer = _timer;
    }

    public void Enter()
    {
        enemy.EnemyAggro = enemy.EnemyAggro + 0.5f;
    }
    public void Physics()
    {
        physics.Move();
    }
    public void Process()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            enemy.CheckForAttack();
        }
        else
        {
            enemy.SwitchRandomState();
        }
    }
    public void Exit()
    { }
}
