using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Controlador del movimiento de la plataforma
public class MovimientoPlataformaController : MonoBehaviour
{
   public IMovimientoPlataforma movimiento;

    void Start()
    {
        movimiento = new MovimientoPlataformaVertical(transform);
    }

    void Update()
    {
        movimiento.Mover(transform);
    }
}
