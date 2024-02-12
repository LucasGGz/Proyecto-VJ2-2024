using UnityEngine;

// Contiene la logica del objeto que se activa/desactiva.

public class ObjetoActivable : MonoBehaviour
{
    [SerializeField] private Transform spawnObjectPrefab;
    private Transform spawnedObject;

    // Método para instanciar el objeto
    public void InstantiarObjeto()
    {
        // Verifica si ya hay una instancia creada
        if (spawnedObject == null)
        {
            spawnedObject = Instantiate(spawnObjectPrefab);
        }
    }

    // Método para desactivar el objeto
    public void DesactivarObjeto()
    {
        // Verifica si hay una instancia antes de intentar desactivarla
        if (spawnedObject != null)
        {
            Destroy(spawnedObject.gameObject);
            spawnedObject = null;
        }
    }
}
