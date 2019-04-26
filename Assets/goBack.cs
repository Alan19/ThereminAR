using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goBack : MonoBehaviour, RaycastHitHandler {
    public void OnPoint(bool down)
    {
        if (down)
        {
            SceneManager.LoadScene("TitleScene");
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

}
