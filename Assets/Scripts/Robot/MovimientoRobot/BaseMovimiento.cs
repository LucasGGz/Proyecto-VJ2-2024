using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseMovimiento : IMovable
{
    public abstract void Move(Transform transform, float speed);
}
