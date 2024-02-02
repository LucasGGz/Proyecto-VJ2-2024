using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarNaves : MonoBehaviour
{
    public float rotationSpeed = 10f; // Velocidad de rotación
    private IRotator rotator;

    void Start()
    {
        rotator = new NaveRotator();
    }

    void Update()
    {
        rotator.Rotate(transform, rotationSpeed * Time.deltaTime);
    }
}