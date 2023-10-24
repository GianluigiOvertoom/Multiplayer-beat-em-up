using System.Collections.Generic;
using UnityEngine;

public class HitboxCollection
{
    public string Name;
    public List<GameObject> Targets = new List<GameObject>();
    
    public HitboxCollection(string name)
    {
        Name = name;
    }
}
