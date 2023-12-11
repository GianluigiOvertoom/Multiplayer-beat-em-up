using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEnemyR_State_Retreat : IEntityState
{
    private TEnemyR enemy;
    private EnemyPhysics physics;
    private float timer;

    public TEnemyR_State_Retreat(TEnemyR tEnemy, float _timer = 1.5f)
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
        physics.MoveFromTargetXZ();
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
            enemy.SwitchState(new TEnemyR_State_Idle(enemy, 0.5f));
        }
    }
    public void Exit()
    { }
}
