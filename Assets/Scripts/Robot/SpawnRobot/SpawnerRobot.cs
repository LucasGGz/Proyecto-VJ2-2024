using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clase que se encarga de spawnear robots en el juego.
public class SpawnerRobot : MonoBehaviour
{
    [SerializeField] private RobotFactory robotFactory;
    
    void Start()
    {
        robotFactory.Create("Robot1"); //Crea y devuelve el robot1.
    
        robotFactory.Create("Robot2"); //Crea y devuelve el robot2.
    
        robotFactory.Create("Robot3"); //Crea y devuelve el robot3.
      
        robotFactory.Create("Robot4"); //Crea y devuelve el robot4.

    }

           
}
