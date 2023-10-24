using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityAnimationEvents : MonoBehaviour
{
    public bool CastHitbox = false;
    public bool AnimationFinished = false;

    /*private void PlaySound(string name) => AudioManager.Play(name);
    private void StopSound(string name) => AudioManager.Stop(name);*/

    private void StartHitboxCast() => CastHitbox = true;
    private void StopHitboxCast() => CastHitbox = false;

    private void FinishAnimation() => AnimationFinished = true;
}
