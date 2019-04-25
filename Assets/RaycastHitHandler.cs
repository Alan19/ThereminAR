using UnityEngine;

public interface RaycastHitHandler
{
    void OnPointEnter(bool down);  
    void OnPoint(bool down);
    void OnPointLeave(bool down);
}