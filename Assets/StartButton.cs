using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour, RaycastHitHandler {
    public void HandleRaycastHit(RaycastHit rh)
    {
        SceneManager.LoadScene("BasicScene");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
