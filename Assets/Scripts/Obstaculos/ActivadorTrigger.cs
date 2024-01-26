using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorTrigger : MonoBehaviour
{
    [SerializeField] private GeneradorObstaculos generador;

    private bool activadorActivo = true; // Variable para controlar si el activador est� activo

    private void OnTriggerEnter(Collider other)
    {
        if (activadorActivo && other.CompareTag("Player"))
        {
            generador.InstantiarObstaculoServerRpc();

            // Desactivar el activador despu�s de activar el generador
            activadorActivo = false;
            gameObject.SetActive(false);
        }
    }
}