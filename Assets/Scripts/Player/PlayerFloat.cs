using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFloat : MonoBehaviour
{
    private float amplitude = 0.15f;
    private float frequency = 1.5f;
    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        float newY = startPosition.y + Mathf.Sin(Time.time * frequency) * amplitude;
        transform.position = new Vector3(startPosition.x, newY, startPosition.z);
    }
}
