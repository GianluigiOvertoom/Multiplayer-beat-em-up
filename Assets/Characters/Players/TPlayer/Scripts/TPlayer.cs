using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPlayer : Player
{
    protected override void Start()
    {
        base.Start();
        PlayerState = new TPlayer_State_Idle(this);
    }

    protected override void Update()
    {
        base.Update();
        //Debug.Log(PlayerState);
    }
}
