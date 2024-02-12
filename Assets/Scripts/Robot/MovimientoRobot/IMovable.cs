using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Interfaz IMovable que define un método de movimiento.
public interface IMovable
{
   void Move(Transform transform, float speed);
}
