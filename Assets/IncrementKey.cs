using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncrementKey : MonoBehaviour, RaycastHitHandler {
    public TextMesh textMesh;

    public void HandleRaycastHit(RaycastHit rh)
    {
        if (textMesh.text.Equals("A"))
        {
            textMesh.text = "B";
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
