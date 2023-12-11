using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TEnemyR : Enemy
{
    public float EnemyAggro;
    private float minimalDistance = 1.25f;
    protected override void Start()
    {
        base.Start();
        EnemyAggro = 0;
        EnemyState = new TEnemyR_State_Idle(this);
    }

    protected override void Update()
    {
        base.Update();
        //MoveTowardsTarget(targetPoint.transform.position);
        //Debug.Log(EnemyState);
    }

    public void CheckForAttack()
    {
        if (Vector3.Distance(transform.position, Physics.Target.transform.position) < minimalDistance)
        {
            SwitchState(new TEnemyR_State_Attack(this));
        }
    }

    public void SwitchRandomState()
    {
        float amount = Random.Range(0, 4);
        switch (amount)
        {
            case 0:
                SwitchState(new TEnemyR_State_Idle(this, 1f));
                break;
            case 1:
                SwitchState(new TEnemyR_State_Retreat(this, 0.5f));
                break;
            case 2:
                //Patrol to a random point
                SwitchState(new TEnemyR_State_Chase(this, 0.5f));
                break;
            case 3:
                SwitchState(new TEnemyR_State_Chase(this, 0.75f));
                break;
        }
    }
}
