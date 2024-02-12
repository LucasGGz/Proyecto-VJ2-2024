using UnityEngine;

// Clase que controla la rotación de planetas
public class RotarPlanetas : MonoBehaviour
{
    public float rotationSpeed = 10f;
    void Update()
    {
        // Rotar el objeto alrededor del eje Y
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}

