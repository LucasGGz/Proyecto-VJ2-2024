using UnityEngine;

// Clase que se encarga del MovimientoAdelanteAtras.
public class MovimientoAdelanteAtras : BaseMovimiento
{
    // Metodo de la interfaz IMovable para movimiento adelante y atras
    public override void Move(Transform transform, float speed)
    {
        float forwardOffset = Mathf.Sin(Time.time * speed) * 2f;

        transform.position += new Vector3(0f, 0f, forwardOffset) * Time.deltaTime;
    }
}
