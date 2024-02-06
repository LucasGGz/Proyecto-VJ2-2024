using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class FallPlayer : NetworkBehaviour
{
    private Vector3 limit, limit2, limit3;
    void Start()
    {
        limit = new Vector3(0, 2f, 0);
        limit2 = new Vector3(0, 3f, 90f);
        limit3 = new Vector3(4, 3f, 180f);
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsOwner) return;
        /*   if (transform.position.y <= -50f)
           {
               transform.position = limit;
               Debug.Log("se cayo");
           }*/
        if (transform.position.y <= -50f)
        {
            if (transform.position.z > 107)
            {
                transform.position = limit3;
            }
            else if (transform.position.z > 80)
            {
                transform.position = limit2;
            }
            else
            {
                transform.position = limit;
            }

            Debug.Log("Se cayó");
        }
    }
}
