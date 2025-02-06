using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    public float SmoothSpeed = 8f;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        if (target == null) return;

        
    }
}
