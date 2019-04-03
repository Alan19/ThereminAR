using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecrementKey : MonoBehaviour, RaycastHitHandler {
    public TextMesh textMesh;

    public void HandleRaycastHit(RaycastHit rh)
    {
        if(textMesh.text.Equals("B"))
        {
            textMesh.text = "A";
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
