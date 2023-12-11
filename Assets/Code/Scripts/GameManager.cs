using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        Application.targetFrameRate = 120;
        QualitySettings.vSyncCount = 1;
    }
    private void Start()
    {
        Input.Enable();
        Input.EnableGamePlayInput();
    }
}
