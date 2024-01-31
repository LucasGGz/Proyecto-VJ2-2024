using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class ColliderActive : NetworkBehaviour
{
    private bool band = true;
    ActivePremioPJ activePj;
    void Start()
    {
        activePj = GetComponent<ActivePremioPJ>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        // Verificar si el objeto que colisionó tiene la etiqueta "Player"
        if (collider.CompareTag("Estructura") && band)
        {
            band = false;
            activePj.ActiveServerRpc();
            Debug.Log("ActivastePremio");
        }
    }
}
