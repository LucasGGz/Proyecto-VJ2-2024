using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorTrigger : MonoBehaviour
{
    [SerializeField] private ActivadorGenerador generador;
    [SerializeField] private ActivadorGenerador generadorInvertido;

    //Metodo de collision
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            generador.ActivarGenerador(false); // Generador normal
            generadorInvertido.ActivarGenerador(true); // Generador invertido

            gameObject.SetActive(false);
        }
    }

}