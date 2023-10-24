using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEntityState
{
    public void OnEnter();
    public void HandlePhysics();
    public void HandleBehavior();
    public void OnExit();
}

public class Entity : MonoBehaviour
{
    public virtual void HitBoxInteraction(GameObject other, float damage, HitType hitType, bool vortex)
    {
        print(other.name + " interacted with: " + gameObject.name);
    }
}
