using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class ObjectPremio : NetworkBehaviour
{
    public Transform playerPos;
    private float dist;
    private float angulo = 0;

    void Start()
    {
        // Inicializar la distancia entre el premio y el jugador
        dist = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        // Calcular la posición del premio alrededor del jugador utilizando funciones
        float pos_x = playerPos.position.x + Mathf.Cos(angulo * Mathf.Deg2Rad) * dist;
        float pos_y = playerPos.position.y + 1f;
        float pos_z = playerPos.position.z + Mathf.Sin(angulo * Mathf.Deg2Rad) * dist;
        // Actualizar la posición del premio
        transform.position = new Vector3(pos_x, pos_y, pos_z);

    }
}
