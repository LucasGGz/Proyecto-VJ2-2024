using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotFactory: MonoBehaviour
{
    [SerializeField] private Robot[] robots;
    
    public Robot Create (string id)
    {
        Robot robt = null;

        foreach(var robot in robots)
        {
            if(robot.Id == id)
            {
              robt = robot;
              break;
            }
        }
        return robt;
    }
}
