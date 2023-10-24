using System.Collections.Generic;
using UnityEngine;

public enum HitType
{
    basic,
    up,
    back,
    down
}

public class HitBox
{
    private List<GameObject> intersections = new List<GameObject>();

    public string Tag;
    public GameObject Parent;
    public Color Color;
    public Vector3 Point;
    public Vector3 Size;
    public float Damage;

    //Enemy only
    public HitType HitType;
    public bool Vortex;

    private Vector3 offset;
    private LayerMask layer;

    public HitBox(string name, GameObject parent, Vector3 size, float direction, Vector3 offset, LayerMask layer, float damage = 0f, Color color = default, HitType hitType = HitType.basic, bool vortex = false)
    {
        Tag = name;
        Parent = parent;
        Size = size;
        this.offset = offset;
        this.layer = layer;
        Damage = damage;
        if (color == default)
            Color = Color.white;
        else
            Color = color;

        HitType = hitType;
        Vortex = vortex;

        UpdatePointPosition(direction);
    }

    public void UpdatePointPosition(float direction = 1f) => Point = (Vector3)Parent.transform.position + new Vector3(offset.x * direction, offset.y, offset.z);

    public List<GameObject> Cast()
    {
        foreach (Collider intersections in Physics.OverlapBox(Point, Size, Quaternion.identity, layer))
        {
            if (!this.intersections.Contains(intersections.gameObject))
                this.intersections.Add(intersections.gameObject);
        }
        return intersections;
    }
}
