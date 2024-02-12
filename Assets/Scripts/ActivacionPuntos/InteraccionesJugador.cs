using UnityEngine;

//Maneja las interacciones del jugador.

public class InteraccionesJugador : MonoBehaviour
{
    [SerializeField] private ActivadorObjeto activadorObjeto;

    // Se ejecuta cuando un objeto entra en el área de colisión
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            activadorObjeto.Activar();
        }
    }

    // Se ejecuta cuando un objeto sale del área de colisión
    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            activadorObjeto.Desactivar();
        }
    }
}

