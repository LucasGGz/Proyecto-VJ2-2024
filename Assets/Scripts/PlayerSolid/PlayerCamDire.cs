using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamDire : MonoBehaviour
{
    private Vector3 camForward;
    private Vector3 camRight;
    public GameObject Camara3era;

    public Vector3 CamRight { get => camRight; set => camRight = value; }
    public Vector3 CamForward { get => camForward; set => camForward = value; }

    // Update is called once per frame
    void Update()
    {
        camDirection();
    }

    public void camDirection()
    {
        CamForward = Camara3era.transform.forward;
        CamRight = Camara3era.transform.right;

        camForward.y = 0;
        camRight.y = 0;

        CamForward = CamForward.normalized;
        CamRight = CamRight.normalized;
    }
}
