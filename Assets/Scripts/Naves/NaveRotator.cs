using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveRotator : IRotator
{
    public void Rotate(Transform transform, float rotationSpeed)
    {
        // Rotar el objeto alrededor del eje Y
        transform.Rotate(Vector3.up, rotationSpeed);
    }
}
