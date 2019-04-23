using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour, RaycastHitHandler {

    public void HandleRaycastHit(RaycastHit rh)
    {
        GetComponent<MeshRenderer>().enabled = true;
        return;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
