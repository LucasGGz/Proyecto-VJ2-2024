using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject prefabRobot1;
    public GameObject prefabRobot2;
    
    void Start()
    {
        // Utilizando la fábrica de Bloques de Energía
        IFabricaRobot fabricaRobot1 = new FabricaRobot1();
        IRobot robot1 = fabricaRobot1.CrearRobot();
        robot1.Mostrar();

        // Utilizando la fábrica de Escudos Magnéticos
        IFabricaRobot fabricaRobot2 = new FabricaRobot2();
        IRobot robot2 = fabricaRobot2.CrearRobot();
        robot2.Mostrar();
    }
}

