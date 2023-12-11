using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEnemyR_State_Attack : IEntityState
{
    private TEnemyR enemy;
    private EnemyPhysics physics;

    private string attackName;
    private Vector3 attackSize;
    private Vector3 attackOffset;

    //Debug
    private float attackTimer;
    //
    public TEnemyR_State_Attack(TEnemyR tEnemy)
    {
        enemy = tEnemy;
        physics = enemy.Physics;
    }

    public void Enter()
    {
        //Debug
        attackTimer = 0.25f;
        //
        physics.Velocity = new Vector3(0f, physics.Velocity.y, 0f);
        attackName = "E_Attack";
        float Xpos = (physics.FaceDirection == 1) ? physics.Controller.bounds.max.x + 0.35f : physics.Controller.bounds.min.x - 0.35f;

        attackSize = new Vector3(0.5f, 0.5f, 0.5f);
        attackOffset = new Vector2(1f, 1f);

        DamageData damage = new DamageData(1f);

        HitBoxes.AddHitBox(new HitBox(attackName,
            enemy.gameObject, attackSize, physics.FaceDirection,
            attackOffset, physics.TargetMask, damage, Color.red));
    }
    public void Physics()
    {
        /*physics.ApplyGravity();
        physics.Move();*/
        HitBoxes.GetHitBox(attackName).UpdatePointPosition(physics.FaceDirection);
        HitBoxes.CastBoxes(attackName);
    }
    public void Process()
    {
        if (attackTimer <= 0f)
        {
            enemy.SwitchState(new TEnemyR_State_Retreat(enemy));
        }
        else
        {
            attackTimer -= Time.deltaTime;
        }
    }

    public void Exit()
    {
        HitBoxes.RemoveHitBox(attackName);
    }
}
