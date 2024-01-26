using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerRobot : MonoBehaviour
{
    [SerializeField] private RobotFactory robotFactory;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(robotFactory.Create("Robot1")); //Devuelve el robot1 y lo instancia.
        Instantiate(robotFactory.Create("Robot2")); //Devuelve el robot1 y lo instancia.
    }

    // Update is called once per frame
    void Update()
    {

    }
           
}
