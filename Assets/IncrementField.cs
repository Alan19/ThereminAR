using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncrementField : MonoBehaviour, RaycastHitHandler {
    public TextMesh textMesh;

    public void HandleRaycastHit(RaycastHit rh)
    {
        int val;
        Int32.TryParse(textMesh.text, out val);
        val++;
        textMesh.text = val.ToString();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
