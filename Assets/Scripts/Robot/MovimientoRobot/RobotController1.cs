using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clase RobotController1 que controla el movimiento del Robot1.
public class RobotController1 : MonoBehaviour
{
    private BaseMovimiento mover;

    // Al iniciar, se asigna el movimiento adelante y atrás al robot.
    void Start()
    {
        mover = new MovimientoAdelanteAtras();
    }

    // En cada frame, se mueve el robot con una velocidad específica.
    void Update()
    {
        mover.Move(transform, 3f);
    }
}
