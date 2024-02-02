using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Isortable 
{
    public IEnumerator BubbleSort(GameObject[] unsortedList);
}
