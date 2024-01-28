using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController2 : MonoBehaviour
{
    private BaseMovimiento mover;
    // Start is called before the first frame update
    void Start()
    {
        mover = new MovimientoRotacional();
    }

    // Update is called once per frame
    void Update()
    {
        mover.Move(transform, 30f);
    }
}

