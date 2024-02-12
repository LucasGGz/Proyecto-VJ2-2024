using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clase RobotController3 que controla el movimiento del Robot3.
public class RobotController3 : MonoBehaviour
{
    private BaseMovimiento mover;
    // Start is called before the first frame update
    void Start()
    {
        mover = new MovimientoZigZag();
    }

    // Update is called once per frame
    void Update()
    {
        mover.Move(transform, 9f);
    }
}
