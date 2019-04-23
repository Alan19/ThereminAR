using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : RaycastHitHandler {
    public void HandleRaycastHit(RaycastHit rh)
    {
        SceneManager.LoadScene("BasicScene");
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
