using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clase RobotController2 que controla el movimiento del Robot2.
public class RobotController2 : MonoBehaviour
{
    private BaseMovimiento mover;
    // Start is called before the first frame update
    void Start()
    {
        mover = new MovimientoLateral();
    }

    // Update is called once per frame
    void Update()
    {
        mover.Move(transform, 7f);
    }
}

