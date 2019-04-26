using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsButton : MonoBehaviour, RaycastHitHandler {

    public void OnPoint(bool down)
    {
        if (down)
        {
            SceneManager.LoadScene("Settings Scene");
        }
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
