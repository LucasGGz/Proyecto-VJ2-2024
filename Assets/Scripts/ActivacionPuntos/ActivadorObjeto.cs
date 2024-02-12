using UnityEngine;

//Se encarga de activar/desactivar el objeto.

public class ActivadorObjeto : MonoBehaviour
{
    [SerializeField] private ObjetoActivable objetoActivable;

    // Método para activar el objeto
    public void Activar()
    {
        objetoActivable.InstantiarObjeto();
    }

    // Método para desactivar el objeto
    public void Desactivar()
    {
        objetoActivable.DesactivarObjeto();
    }
}
