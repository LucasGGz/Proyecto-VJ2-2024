using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CamaraFunctFollow : MonoBehaviour
{
    [SerializeField] private Transform follow;
    CamaraFunctColl CamaraFunctColl;
    CamaraFunctOrbit camOrbit;

    public Transform Follow { get => follow; set => follow = value; }
    void Start()
    {
        camOrbit = GetComponent<CamaraFunctOrbit>();
        CamaraFunctColl = GetComponent<CamaraFunctColl>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = follow.position + camOrbit.CalculoOrbitacionCam() * CamaraFunctColl.Distance; //para que la cam siga al jugador y pueda rodear al pj
        transform.rotation = Quaternion.LookRotation(follow.position - transform.position); //para que la cam pueda rotar al jguador 
    }
}
