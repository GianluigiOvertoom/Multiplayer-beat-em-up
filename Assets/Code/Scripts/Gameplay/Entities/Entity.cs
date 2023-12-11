using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEntityState
{
    void Enter();
    void Physics();
    void Process();
    void Exit();
}

public class Entity : MonoBehaviour
{
    public bool CanBeHit = true;

    public virtual void HitBoxInteraction(GameObject other, DamageData damage)
    {
        print(other.name + " interacted with: " + gameObject.name);
    }
}
