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

    void OnTriggerEnter(Collider collider)
    {
        // Verificar si el objeto que colisionó tiene la etiqueta "PremioEstructura" y activa el Premio al jugador
        if (collider.CompareTag("PremioEstructura") && band)
        {
            band = false;
            activePj.ActiveServerRpc(); //activa el premio
            Debug.Log("ActivastePremio");
        }
    }
}
