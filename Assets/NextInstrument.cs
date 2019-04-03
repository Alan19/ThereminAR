using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextInstrument : MonoBehaviour, RaycastHitHandler {
    public TextMesh textMesh;

    public void HandleRaycastHit(RaycastHit rh)
    {
        if (textMesh.text.Equals("Piano"))
        {
            textMesh.text = "Violin";
        }
    }

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
