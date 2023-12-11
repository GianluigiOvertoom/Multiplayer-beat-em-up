using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWaypoint : MonoBehaviour
{
    [SerializeField] private GameObject wayPoint;
    [SerializeField] private Collider player;
    [SerializeField] private float radius = 0.5f;
    [Header("Ranges")]
    [SerializeField] private float closeRange;
    [SerializeField] private float midRange;
    [SerializeField] private float farRange;
    [Header("Negative points")]
    [SerializeField] private GameObject NegativeClosePoint;
    [SerializeField] private GameObject NegativeMidPoint;
    [SerializeField] private GameObject NegativeFarPoint;
    [Header("Negative points")]
    [SerializeField] private GameObject PositiveClosePoint;
    [SerializeField] private GameObject PositiveMidPoint;
    [SerializeField] private GameObject PositiveFarPoint;

    private void Update()
    {
        NegativeClosePoint.transform.position = new Vector3((player.transform.position.x + player.bounds.min.x) - closeRange, 0f, player.transform.position.z);
        PositiveClosePoint.transform.position = new Vector3((player.transform.position.x + player.bounds.max.x) + closeRange, 0f, player.transform.position.z);
    }
}
