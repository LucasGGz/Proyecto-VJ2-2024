using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FabricaRobot2 : IFabricaRobot
{
    public IRobot CrearRobot()
    {
        return new Robot2();
    }
}

