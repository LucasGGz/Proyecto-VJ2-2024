using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clase RobotController4 que controla el movimiento del Robot4.
public class RobotController4 : MonoBehaviour
{
    private BaseMovimiento mover;

    void Start()
    {
        mover = new MovimientoRotacional();
    }

    void Update()
    {
        mover.Move(transform, 40f);
    }
}
