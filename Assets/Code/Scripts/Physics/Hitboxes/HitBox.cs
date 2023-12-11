using System.Collections.Generic;
using UnityEngine;

public enum DamageType
{
    hit,
    back,
    up,
    down
}
public class DamageData
{
    public float Damage;
    public DamageType Type;
    public bool Vortex;
    public float VerticalForce;
    public float HorizontalForce;
    public DamageData(float damage, DamageType damageType = DamageType.hit, bool vortex = false, float verticalForce = 0, float horizontalForce = 0)
    {
        Damage = damage;
        Type = damageType;
        Vortex = vortex;
        VerticalForce = verticalForce;
        HorizontalForce = horizontalForce;
    }
}

public class HitBox
{
    private List<GameObject> intersections = new List<GameObject>();

    public string Tag;
    public GameObject Parent;
    public Color Color;
    public Vector3 Point;
    public Vector3 Size;
    public DamageData Damage;

    public Vector3 Offset;
    private LayerMask layer;

    public HitBox(string name, GameObject parent, Vector3 size, float direction, Vector2 _offset, LayerMask _layer, DamageData damage = null, Color color = default)
    {
        Tag = name;
        Parent = parent;
        Size = size;
        Offset = _offset;
        layer = _layer;
        Damage = damage;
        if (color == default)
            Color = Color.white;
        else
            Color = color;

        UpdatePointPosition(direction);
    }

    public void UpdatePointPosition(float direction = 1f) => Point = (Vector3)Parent.transform.position + new Vector3(Offset.x * direction, Offset.y);

    public List<GameObject> Cast()
    {
        foreach (Collider intersection in Physics.OverlapBox(Point, Size, Quaternion.identity, layer))
        {
            if (!intersections.Contains(intersection.gameObject))
                intersections.Add(intersection.gameObject);
        }
        return intersections;
    }
}
