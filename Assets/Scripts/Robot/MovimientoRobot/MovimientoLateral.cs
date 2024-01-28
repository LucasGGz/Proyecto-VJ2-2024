using UnityEngine;

public class MovimientoLateral : BaseMovimiento
{
    // Método de la interfaz IMovable para movimiento lateral
    public override void Move(Transform transform, float speed)
    {
        // Calcula el desplazamiento lateral basado en el tiempo y la velocidad
        float sideOffset = Mathf.Sin(Time.time * speed) * 6f; // Modifica el valor 2f para cambiar la amplitud del movimiento

        // Mueve el objeto en el eje X
        transform.position += new Vector3(sideOffset, 0f, 0f) * Time.deltaTime;
    }
}
