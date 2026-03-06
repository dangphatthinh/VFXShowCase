using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Cinemachine;

public class HS_CinemachineShake : MonoBehaviour
{
    CinemachineImpulseSource impulse;
    void Start()
    {
        impulse = transform.GetComponent<CinemachineImpulseSource>();
    }

    void Update()
    {
    }

    public void Shake()
    {
        impulse.GenerateImpulse();
    }
}
