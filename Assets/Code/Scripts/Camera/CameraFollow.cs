using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Unity.Services.Lobbies.Models;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private PlayerController[] players;
    [SerializeField] private GameObject followingPlayer;
    private Camera mainCamera;
    private float camYPosition;
    private bool AllowCameraMovemnt;

    private void Start()
    {
        players = GameObject.FindObjectsOfType<PlayerController>();
        mainCamera = Camera.main;
        camYPosition = 0f;
        AllowCameraMovemnt = true;
    }

    private void LateUpdate()
    {
        followingPlayer = GetClosestPlayer();
        if (followingPlayer != null && AllowCameraMovemnt)
        {
            FollowPlayer();
        }
    }

    private void FollowPlayer()
    {
        transform.position = new Vector3(followingPlayer.transform.position.x, camYPosition, -10f);
    }

    private GameObject GetClosestPlayer()
    {
        GameObject closestPlayer = gameObject;
        float leastDistance = Mathf.Infinity;

        Vector2 rightCamEdge = mainCamera.ScreenToWorldPoint(new Vector3(mainCamera.pixelWidth, 0));

        foreach (var player in players)
        {
            Vector2 playerPos = new Vector2(player.transform.position.x, 0);
            float edgeDistance = Vector2.Distance(playerPos, rightCamEdge);

            if (edgeDistance < leastDistance)
            {
                leastDistance = edgeDistance;
                closestPlayer = player.gameObject;
            }
        }
        return closestPlayer;
    }

    public void LockCamera(Vector3 lockPosition)
    {
        AllowCameraMovemnt = false;
        transform.position = lockPosition;
    }

    public void UnlockCamera()
    {
        AllowCameraMovemnt = true;
    }

    public void UpdateYposition(float newYposition)
    {
        camYPosition = newYposition;
    }
}
