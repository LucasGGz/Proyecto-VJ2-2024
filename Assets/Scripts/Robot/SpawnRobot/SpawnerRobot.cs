using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clase que maneja la creacion y el spawn de robots en el juego.
public class SpawnerRobot : MonoBehaviour
{
    [SerializeField] private RobotFactory robotFactory;
    
    void Start()
    {
        Robot robot1 = robotFactory.Create("Robot1"); //Devuelve el robot1 y lo instancia.
        Instantiate(robot1);
    
        Robot robot2 = robotFactory.Create("Robot2"); //Devuelve el robot2 y lo instancia.
        Instantiate(robot2);
    
        Robot robot3 = robotFactory.Create("Robot3"); //Devuelve el robot3 y lo instancia.
        Instantiate(robot3);
      
        Robot robot4 = robotFactory.Create("Robot4"); //Devuelve el robot4 y lo instancia.
        Instantiate(robot4);

    }

           
}
