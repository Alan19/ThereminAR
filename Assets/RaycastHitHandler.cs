using UnityEngine;

public interface RaycastHitHandler
{
    void HandleRaycastHit(RaycastHit rh);
    void HandleRaycastHover(RaycastHit rh);
}