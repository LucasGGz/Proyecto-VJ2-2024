using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class FallPlayer : NetworkBehaviour
{
    private Vector3 limit;
    void Start()
    {
        limit = new Vector3(0, 2f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsOwner) return;
        if (transform.position.y <= -50f)
        {
            transform.position = limit;
            Debug.Log("se cayo");
        }
    }
}
