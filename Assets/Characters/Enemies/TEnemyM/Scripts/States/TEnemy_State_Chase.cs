using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEnemy_State_Chase : IEntityState
{
    private TEnemyM enemy;
    private EnemyPhysics physics;
    private float timer;

    public TEnemy_State_Chase(TEnemyM tEnemy, float _timer = 1.5f)
    {
        enemy = tEnemy;
        physics = enemy.Physics;
        timer = _timer;
    }

    public void Enter()
    {
        enemy.EnemyAggro = 0;
    }
    public void Physics()
    {
        physics.MoveTowardsTargetXZ();
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
            enemy.SwitchState(new TEnemy_State_Idle(enemy, 1.5f));
        }
    }
    public void Exit()
    { }
}
