using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecrementKey : RaycastHitHandler {
    public TextMesh textMesh;

    public void HandleRaycastHit(RaycastHit rh)
    {
        if(textMesh.text.Equals("B"))
        {
            textMesh.text = "A";
        }
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
