using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour, RaycastHitHandler {
    public void OnPoint(bool down)
    {
        if (down)
        {
            SceneManager.LoadScene("BasicScene");
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
