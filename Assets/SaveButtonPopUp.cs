using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveButtonPopUp : RaycastHitHandler {
    public TextMesh text;

    public void HandleRaycastHit(RaycastHit rh)
    {
        text.text = "Composition Saved!";
    }

    public override void OnPoint(bool down)
    {
        throw new System.NotImplementedException();
    }

    public override void OnPointEnter(bool down)
    {
        throw new System.NotImplementedException();
    }

    public override void OnPointLeave(bool down)
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
