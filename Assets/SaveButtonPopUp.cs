using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveButtonPopUp : MonoBehaviour, RaycastHitHandler {
    public TextMesh text;

    public void HandleRaycastHit(RaycastHit rh)
    {
        text.text = "Composition Saved!";
    }

    public void OnPoint(bool down)
    {
        throw new System.NotImplementedException();
    }

    public void OnPointEnter(bool down)
    {
        throw new System.NotImplementedException();
    }

    public void OnPointLeave(bool down)
    {
        throw new System.NotImplementedException();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
