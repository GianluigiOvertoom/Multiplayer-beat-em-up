using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBox : Entity
{
    private MeshRenderer meshRenderer;
    private Material originalMat;
    [SerializeField] private Material hitMat;
    
    private float attackedTimer;
    private bool gettingHit;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        originalMat = meshRenderer.material;

        gettingHit = false;
        attackedTimer = 0;
    }

    private void Update()
    {
        if (!gettingHit) 
        {
            return;
        }
        if (attackedTimer <= 0) 
        {
            meshRenderer.material = originalMat;
            gettingHit = false;
        }
        else
        {
            attackedTimer -= Time.deltaTime;
        }
    }

    public override void HitBoxInteraction(GameObject other, DamageData damage)
    {
        base.HitBoxInteraction(other, damage);
        if (damage.Damage > 0f) 
        {
            attackedTimer = 0.2f;
            gettingHit = true;
            meshRenderer.material = hitMat;
        }
    }
}
