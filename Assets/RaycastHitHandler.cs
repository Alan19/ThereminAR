using UnityEngine;

public abstract class RaycastHitHandler
{
    abstract void OnPointEnter(bool down);
    abstract void OnPoint(bool down);
    abstract void OnPointLeave(bool down);
}