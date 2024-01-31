using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
