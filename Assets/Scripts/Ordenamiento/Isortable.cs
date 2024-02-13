using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Interfaz para poder dar la logica del algoritmo Bubble Sort 
public interface Isortable 
{
    public IEnumerator BubbleSort(GameObject[] unsortedList);
}
