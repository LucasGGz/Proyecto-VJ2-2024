using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class Initialize : NetworkBehaviour, Iinitializable
{
    [SerializeField] private GameObject[] Cubes;
  //  [SerializeField] private GameObject ubicacion;
    public GameObject[] inst;

    public void InitializeRandom()
    {
        inst = new GameObject[Cubes.Length];

        float spacing = 0.1f; // Espacio en el eje X entre los cubos

        for (int i = 0; i < Cubes.Length; i++)
        {
            // Instanciar el prefab
            GameObject instancia = Instantiate(Cubes[i]);

            // Ajustar la posici�n con espacio en el eje X
            instancia.transform.position = new Vector3(i * (instancia.transform.localScale.x + spacing) +96, instancia.transform.localScale.y / 2 + 2f, 183f);
            //   instancia.transform.parent = this.transform;
            // Almacena la instancia en el array
            inst[i] = instancia;
        }

    }
}
