using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerRobot : MonoBehaviour
{
    [SerializeField] private RobotFactory robotFactory;
    // Start is called before the first frame update
    
    void Start()
    {
        Robot robot1 = robotFactory.Create("Robot1"); //Devuelve el robot1 y lo instancia.
        Instantiate(robot1);
        //robot1.Move();
        Robot robot2 = robotFactory.Create("Robot2"); //Devuelve el robot1 y lo instancia.
        Instantiate(robot2);
        //robot2.Move();
        Robot robot3 = robotFactory.Create("Robot3"); //Devuelve el robot1 y lo instancia.
        Instantiate(robot3);
        //robot3.Move();*/
        Robot robot4 = robotFactory.Create("Robot4"); //Devuelve el robot1 y lo instancia.
        Instantiate(robot4);
        //robot4.Move();
    }

           
}
