using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMetronome : MonoBehaviour, RaycastHitHandler {
    bool on = false;
    public AudioSource MusicSource;
    public AudioClip MusicClip;
    public Material enabledTex;
    public Material originalMat;
    public Renderer rend;


    public void HandleRaycastHit(RaycastHit rh)
    {
    }

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void OnPointEnter(bool down)
    {
        throw new System.NotImplementedException();
    }

    public void OnPoint(bool down)
    {
        MusicSource.clip = MusicClip;
        if (on && down)
        {
            on = false;
            MusicSource.Stop();
            rend.material = originalMat;
        }
        else if (!on && down)
        {
            on = true;
            MusicSource.Play();
            rend.material = enabledTex;
        }

    }

    public void OnPointLeave(bool down)
    {
        throw new System.NotImplementedException();
    }
}
