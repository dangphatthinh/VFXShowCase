using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HS_RepeatShake : MonoBehaviour
{
    [Space]
    [Header("Camera Shaker script")]
    public HS_CameraShaker cameraShaker;
    public float amplitude;
    public float frequency;
    public float duration;
    public float timeRemaining;

    [Space]
    [Header("Repeating")]
    public float repeatingTime = 2.0f;
    public float startTime;
    private float nextActionTime = 0.0f;

    void Start()
    {
        nextActionTime -= startTime;
    }

    void Update()
    {
        nextActionTime += Time.deltaTime;
        if (nextActionTime > 0)
        {
            nextActionTime = -repeatingTime;
            StartCoroutine(cameraShaker.Shake(amplitude, frequency, duration, timeRemaining));
        }
    }
}
