using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class Bubble : NetworkBehaviour, Isortable
{
    // Método de la interfaz, para ordenar una lista de GameObjects utilizando el algoritmo de ordenación de burbuja
    public IEnumerator Sort(GameObject[] unsortedList)
    {
        int n = unsortedList.Length;
        bool swapped;

        // Bucle externo para recorrer todos los elementos del arreglo
        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            // Bucle interno para comparar pares de elementos y realizar intercambios
            for (int j = 0; j < n - i - 1; j++)
            {
                // Cambiar color del objeto actual a azul
                LeanTween.color(unsortedList[j], Color.blue, 0.5f);
                LeanTween.color(unsortedList[j + 1], Color.blue, 0.5f);
                yield return new WaitForSeconds(0.7f);

                // Restaurar el color del objeto comparado
                LeanTween.color(unsortedList[j], Color.white, 0.1f);
                LeanTween.color(unsortedList[j + 1], Color.white, 0.1f);

                // Comparar el tamaño de los elementos y realizar el intercambio si es necesario
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
