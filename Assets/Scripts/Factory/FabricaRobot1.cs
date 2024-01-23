using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FabricaRobot1 : IFabricaRobot
{
    public IRobot CrearRobot()
    {
        return new Robot1();
    }
}
