using UnityEngine.SceneManagement;

public class StartButton : RaycastHitHandler {
    public override void OnPoint(bool down)
    {
        if (down)
        {
            SceneManager.LoadScene("BasicScene");
        }
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
