using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clase que actua como una fabrica de robots.
public class RobotFactory: MonoBehaviour
{
    [SerializeField] private Robot[] robots;
    
    // Metodo para crear un robot dado su ID.
    public Robot Create (string id)
    {
        Robot robt = null;

        // Itera a traves de la lista de robots disponibles.
        foreach(var robot in robots)
        {
             // Si encuentra un robot con el ID proporcionado, lo asigna
            if(robot.Id == id)
            {
              robt = robot;
              break;
            }
        }
        // Retorna el robot encontrado
        return robt;
    }
}
