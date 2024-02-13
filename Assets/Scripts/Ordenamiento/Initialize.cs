using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

//exitende de la interfaz y se cumple el contrato de esta
public class Initialize : NetworkBehaviour, Iinitializable
{
    [SerializeField] private GameObject[] Cubes;
    public GameObject[] inst;

    // Inicializa los cubos 
    public void InitializeRandom()
    {
        // Crea un array para almacenar las instancias de los cubos
        inst = new GameObject[Cubes.Length];

        float spacing = 0.1f; // Espacio en el eje X entre los cubos
        
        // Itera sobre cada cubo en el array Cubes
        for (int i = 0; i < Cubes.Length; i++)
        {
            // Instanciar el prefab 
            GameObject instancia = Instantiate(Cubes[i]);

            // Ajustar la posición con espacio en el eje X
            instancia.transform.position = new Vector3(i * (instancia.transform.localScale.x + spacing) +96, instancia.transform.localScale.y / 2 + 2f, 183f);
            // Almacena la instancia en el array
            inst[i] = instancia;
        }

    }
}
