using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clase RobotController2 que controla el movimiento del Robot2.
public class RobotController2 : MonoBehaviour
{
    private BaseMovimiento mover;

    void Start()
    {
        mover = new MovimientoLateral();
    }

    void Update()
    {
        mover.Move(transform, 7f);
    }
}

