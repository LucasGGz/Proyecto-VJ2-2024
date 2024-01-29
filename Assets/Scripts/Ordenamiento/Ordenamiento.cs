using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class Ordenamiento : NetworkBehaviour
{
    [SerializeField] private GameObject[] Cubes;
    [SerializeField] private GameObject ubicacion;
    private bool genera = true;
    public GameObject[] inst;
    void Start()
    {
      
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player") && genera)
        {
            Debug.Log("Choco");
            InitializeRandom();
            StartCoroutine(BubbleSort(inst));
            genera = false;
        }
    }

    public void InitializeRandom()
    {
        inst = new GameObject[Cubes.Length];

        float spacing = 0.1f; // Espacio en el eje X entre los cubos

        for (int i = 0; i < Cubes.Length; i++)
        {
            // Instanciar el prefab
            GameObject instancia = Instantiate(Cubes[i]);

            // Ajustar la posición con espacio en el eje X
            instancia.transform.position = new Vector3(i * (instancia.transform.localScale.x + spacing)+10, instancia.transform.localScale.y / 2-1, 30);
         //   instancia.transform.parent = this.transform;
            // Almacena la instancia en el array
            inst[i] = instancia;
        }

    }

    public IEnumerator BubbleSort(GameObject[] unsortedList)
    {

        int n = unsortedList.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                // Cambiar color del objeto actual a azul
                LeanTween.color(unsortedList[j], Color.blue, 0.5f);
                LeanTween.color(unsortedList[j + 1], Color.blue, 0.5f);
                yield return new WaitForSeconds(0.7f);

                // Restaurar el color del objeto comparado
                LeanTween.color(unsortedList[j], Color.white, 0.1f);
                LeanTween.color(unsortedList[j + 1], Color.white, 0.1f);

                if (unsortedList[j].transform.localScale.y > unsortedList[j + 1].transform.localScale.y)
                {
                    // Intercambio de elementos
                    GameObject temp = unsortedList[j];
                    unsortedList[j] = unsortedList[j + 1];
                    unsortedList[j + 1] = temp;

                    // Animación de intercambio
                    float tempX = unsortedList[j].transform.localPosition.x;
                    LeanTween.moveLocalX(unsortedList[j], unsortedList[j + 1].transform.localPosition.x, 0.5f);
                    LeanTween.moveLocalX(unsortedList[j + 1], tempX, 0.5f);

                    // Cambiar color del objeto actual a magenta después del intercambio
                    LeanTween.color(unsortedList[j], Color.magenta, 0.6f);
                    yield return new WaitForSeconds(0.7f);
                    LeanTween.color(unsortedList[j], Color.white, 0.5f);

                    // Cambiar color del objeto siguiente a magenta después del intercambio
                    LeanTween.color(unsortedList[j + 1], Color.magenta, 0.6f);
                    yield return new WaitForSeconds(0.7f);
                    LeanTween.color(unsortedList[j + 1], Color.white, 0.5f);

                    swapped = true;
                }
            }

            // Si no se realizaron intercambios en esta iteración, la lista está ordenada
            if (!swapped)
                break;
        }
    }
}
