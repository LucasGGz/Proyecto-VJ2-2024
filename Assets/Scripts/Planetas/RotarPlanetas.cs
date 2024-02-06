using UnityEngine;

public class RotarPlanetas : MonoBehaviour
{
    public float rotationSpeed = 10f; // Velocidad de rotación

    void Update()
    {
        // Rotar el objeto alrededor del eje Y
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}

