using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public static class HitBoxes
{
    public static List<HitBox> HitBoxList = new List<HitBox>();
    private static List<HitboxCollection> HitboxCollections = new List<HitboxCollection>();

    public static void AddHitBox(HitBox hitBox)
    {
        HitBoxList.Add(hitBox);
        if (!HitboxCollections.Any(x => x.Name == hitBox.Tag))
            HitboxCollections.Add(new HitboxCollection(hitBox.Tag));
    }

    public static void RemoveHitBox(string name)
    {
        if (!HitBoxList.Any(x => x.Tag == name))
            return;

        List<HitBox> removableHitbox = new List<HitBox>();
        foreach (HitBox hitBox in HitBoxList)
        {
            if (hitBox.Tag == name)
                removableHitbox.Add(hitBox);
        }
        foreach (HitBox hitBox in removableHitbox)
        {
            HitBoxList.Remove(hitBox);
            if (!HitBoxList.Any(x => x.Tag == name))
                HitboxCollections.Remove(HitboxCollections.Find(x => x.Name == hitBox.Tag));
        }
    }

    public static void CastBoxes(string name)
    {
        if (HitBoxList.Count <= 0)
            return;
        foreach (HitBox hitBox in HitBoxList)
        {
            GameObject parent = hitBox.Parent;
            DamageData damage = hitBox.Damage;
            if (hitBox.Tag == name)
            {               
                foreach (GameObject target in hitBox.Cast())
                {
                    HitboxCollection hitboxCollection = HitboxCollections.Find(x => x.Name == hitBox.Tag);
                    if (!hitboxCollection.Targets.Contains(target) && target.GetComponent<Entity>() != null)
                    {
                        hitboxCollection.Targets.Add(target);
                        Entity entity = target.GetComponent<Entity>();
                        if (entity.CanBeHit)
                        {
                            entity.HitBoxInteraction(parent, damage);
                        }
                    }                 
                }
            }
        }
    }

    public static void ClearHitbox(string name) => HitboxCollections.Find(x => x.Name == name).Targets.Clear();

    public static HitBox GetHitBox(string name)
    {  
        if (HitBoxList.Find(x => x.Tag == name) is HitBox hitBox)
            return hitBox;
        return null;
    }
}
