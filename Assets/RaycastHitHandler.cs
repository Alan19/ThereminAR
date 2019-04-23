using UnityEngine;

public abstract class RaycastHitHandler : MonoBehaviour
{
    public abstract void OnPointEnter(bool down);
    public abstract void OnPoint(bool down);
    public abstract void OnPointLeave(bool down);
}