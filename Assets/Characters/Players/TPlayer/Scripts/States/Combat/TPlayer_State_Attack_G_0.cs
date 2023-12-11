using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class TPlayer_State_Attack_G_0 : IPlayerState
{
    private TPlayer player;
    private PlayerPhysics physics;
    
    private string attackName;
    private Vector3 attackSize;
    private Vector3 attackOffset;
    
    //Debug
    private float attackTimer;
    //
    public TPlayer_State_Attack_G_0(TPlayer tPlayer)
    {
        player = tPlayer;
        physics = player.Physics;
    }

    public void Enter()
    {
        //Debug
        attackTimer = 0.25f;
        //
        physics.Velocity = new Vector3(0f, physics.Velocity.y, 0f);
        attackName = "Attack_G_0";
        float Xpos = (physics.FaceDirection == 1) ? physics.Controller.bounds.max.x + 0.35f : physics.Controller.bounds.min.x - 0.35f;

        attackSize = new Vector3(1f, 0.5f, 1f);
        attackOffset = new Vector2(1.5f, 1.5f);

        DamageData damage = new DamageData(1f);

        HitBoxes.AddHitBox(new HitBox(attackName, 
            player.gameObject, attackSize, physics.FaceDirection,
            attackOffset, physics.TargetMask, damage, Color.yellow));
    }
    public void Physics()
    {
        physics.ApplyGravity();
        physics.Move();
        HitBoxes.GetHitBox(attackName).UpdatePointPosition(physics.FaceDirection);
        HitBoxes.CastBoxes(attackName);
    }
    public void Process()
    {
        if (attackTimer <= 0f) 
        {
            player.SwitchState(new TPlayer_State_Idle(player));
        }
        else 
        {
            attackTimer -= Time.deltaTime;
        }
    }
    public void OnInput()
    { }

    public void Exit()
    {
        HitBoxes.RemoveHitBox(attackName);
    }
}
