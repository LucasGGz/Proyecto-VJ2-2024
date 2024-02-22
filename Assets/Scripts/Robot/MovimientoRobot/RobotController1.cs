using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clase RobotController1 que controla el movimiento del Robot1.
public class RobotController1 : MonoBehaviour
{
    private BaseMovimiento mover;

    void Start()
    {
        mover = new MovimientoAdelanteAtras();
    }

    void Update()
    {
        mover.Move(transform, 3f);
    }
}
