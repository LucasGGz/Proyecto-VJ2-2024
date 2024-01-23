using UnityEngine;

//Se encarga de activar/desactivar el objeto.

public class ActivadorObjeto : MonoBehaviour
{
    [SerializeField] private ObjetoActivable objetoActivable;

    public void Activar()
    {
        objetoActivable.InstantiarObjeto();
    }

    public void Desactivar()
    {
        objetoActivable.DesactivarObjeto();
    }
}
