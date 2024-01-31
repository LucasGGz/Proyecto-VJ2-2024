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
        dist = 1f;


    }
    public void SetJugadorQueChoco(Transform jugador)
    {
        playerPos = jugador;
    }
    // Update is called once per frame
    void Update()
    {
        // transform.Rotate(0, 100 * Time.deltaTime, 0); //hacemos que gire

        if (playerPos != null)
        {
            float pos_x = playerPos.position.x + Mathf.Cos(angulo * Mathf.Deg2Rad) * dist;
            float pos_y = playerPos.position.y + 1f;
            float pos_z = playerPos.position.z + Mathf.Sin(angulo * Mathf.Deg2Rad) * dist;
            transform.position = new Vector3(pos_x, pos_y, pos_z);
        }
    }


}
