using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoockCamera : MonoBehaviour
{
    public GameObject TagCam;
    private void LateUpdate()
    {
        transform.LookAt(transform.position + TagCam.transform.forward);
    }
}
