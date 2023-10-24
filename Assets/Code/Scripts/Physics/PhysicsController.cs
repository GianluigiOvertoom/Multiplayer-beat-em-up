using UnityEngine;

public class PhysicsController : MonoBehaviour
{
    [HideInInspector] public CharacterController Controller;
    [HideInInspector] public Vector3 Velocity;

    public virtual void Start()
    {
        Controller = GetComponent<CharacterController>();
    }

    public virtual void Move()
    {
        Controller.Move(Velocity * Time.deltaTime);
    }
}
