using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class FallPlayer : NetworkBehaviour
{
    private Vector3 limit, limit2, limit3, limitV2, limit4, limit5, limit6, limit7, limit8, limit9;
    void Start()
    {
        limit = new Vector3(0, 2f, 0);
        limit2 = new Vector3(0, 3f, 90f);
        limitV2 = new Vector3(62, 3f, 90f);
        limit3 = new Vector3(4, 3f, 180f);
        limit4 = new Vector3(91f, 5f, 184f);
        limit5 = new Vector3(220, 17, 184f);
        limit5 = new Vector3(220, 17, 184f);
        limit6 = new Vector3(4, 11, 200f);
        limit7 = new Vector3(4, 11, 256f);
        limit8 = new Vector3(4, 11, 340);
        limit9 = new Vector3(4, 11, 412);
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
        if (transform.position.y <= -40f)
        {
            if (transform.position.z > 407)
            {
                transform.position = limit9;
            }
            else if (transform.position.z > 330)
            {
                transform.position = limit8;
            }
            else if (transform.position.z > 248)
            {
                transform.position = limit7;
            }
            else if (transform.position.z > 207f)
            {
                transform.position = limit6;
            }
            else if (transform.position.z > 158 && transform.position.x > 196f)
            {
                transform.position = limit5;
            }
            else if (transform.position.z > 158 && transform.position.x > 84)
            {
                transform.position = limit4;
            }
            else if (transform.position.z > 158)
            {
                transform.position = limit3;
            }
            else if (transform.position.z > 62)
            {
                if (transform.position.x > 44)
                {
                    transform.position = limitV2;
                }
                else
                {
                    transform.position = limit2;
                }
            }
            else
            {
                transform.position = limit;
            }

            Debug.Log("Se cayó");
        }
    }
}
