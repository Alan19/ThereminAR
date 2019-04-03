using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastInstrument : MonoBehaviour, RaycastHitHandler {
    public TextMesh textMesh;

    public void HandleRaycastHit(RaycastHit rh)
    {
        if (textMesh.text.Equals("Violin"))
        {
            textMesh.text = "Piano";
        }
    }

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
