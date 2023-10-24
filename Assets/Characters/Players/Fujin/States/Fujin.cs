using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fujin : PlayerController
{
    protected override void Start()
    {
        base.Start();
        PlayerState = new Fujin_State_Idle(this);
    }
}
