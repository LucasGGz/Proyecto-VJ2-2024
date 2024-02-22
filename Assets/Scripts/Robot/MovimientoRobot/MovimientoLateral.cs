using UnityEngine;

// Clase que se encarga del MovimientoLateral.
public class MovimientoLateral : BaseMovimiento
{
    // Metodo de la interfaz IMovable para movimiento lateral
    public override void Move(Transform transform, float speed)
    {
        float sideOffset = Mathf.Sin(Time.time * speed) * 6f;

        transform.position += new Vector3(sideOffset, 0f, 0f) * Time.deltaTime;
    }
}
