using UnityEngine;

//Maneja las interacciones del jugador.

public class InteraccionesJugador : MonoBehaviour
{
    [SerializeField] private ActivadorObjeto activadorObjeto;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Debug.Log("Choco");
            activadorObjeto.Activar();
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Debug.Log("FUE");
            activadorObjeto.Desactivar();
        }
    }
}

