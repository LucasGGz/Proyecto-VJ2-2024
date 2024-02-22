using UnityEngine;

// Clase que se encarga del MovimientoRotacional.
public class MovimientoRotacional : BaseMovimiento
{
    // Metodo de la interfaz IMovable para rotar el objeto
    public override void Move(Transform transform, float rotationSpeed)
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}

