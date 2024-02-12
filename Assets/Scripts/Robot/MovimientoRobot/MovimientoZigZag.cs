using UnityEngine;

// Clase que se encarga del MovimientoZigZag.
public class MovimientoZigZag : BaseMovimiento
{
    // Método de la interfaz IMovable para movimiento en zigzag
    public override void Move(Transform transform, float speed)
    {
        // Calcula el desplazamiento en el eje X basado en el tiempo y la velocidad
        float sideOffset = Mathf.Sin(Time.time * speed) * 6f;

        // Calcula el desplazamiento en el eje Z basado en el tiempo y la velocidad
        float forwardOffset = Mathf.Cos(Time.time * speed) * 2f;

        // Mueve el objeto en los ejes X y Z
        transform.position += new Vector3(sideOffset, 0f, forwardOffset) * Time.deltaTime;
    }
}
