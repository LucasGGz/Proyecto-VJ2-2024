using UnityEngine;

public class RotarRuedas : MonoBehaviour
{
    public float rotationSpeed = 10f; // Velocidad de rotación de las ruedas

    // Método para configurar la velocidad de rotación desde fuera de la clase
    public void SetRotationSpeed(float speed)
    {
        rotationSpeed = speed;
    }

    void Update()
    {
        // Rotar el objeto alrededor del eje Y
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
