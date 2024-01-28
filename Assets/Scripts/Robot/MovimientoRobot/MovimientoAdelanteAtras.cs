using UnityEngine;

public class MovimientoAdelanteAtras : BaseMovimiento
{
    // Método de la interfaz IMovable para movimiento adelante y atrás
    public override void Move(Transform transform, float speed)
    {
        // Calcula el desplazamiento en el eje Z basado en el tiempo y la velocidad
        float forwardOffset = Mathf.Sin(Time.time * speed) * 15f; // Modifica el valor 2f para cambiar la amplitud del movimiento

        // Mueve el objeto en el eje Z
        transform.position += new Vector3(0f, 0f, forwardOffset) * Time.deltaTime;
    }
}
