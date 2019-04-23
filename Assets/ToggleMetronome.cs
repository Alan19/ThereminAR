using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMetronome : RaycastHitHandler {
    bool on = false;
    public AudioSource MusicSource;
    public AudioClip MusicClip;


    public void HandleRaycastHit(RaycastHit rh)
    {
        MusicSource.clip = MusicClip;
        if (on)
        {
            on = false;
            MusicSource.Stop();
        }
        else
        {
            on = true;
            MusicSource.Play();
        }
    }

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void OnPointEnter(bool down)
    {
        throw new System.NotImplementedException();
    }

    public override void OnPoint(bool down)
    {
        throw new System.NotImplementedException();
    }

    public override void OnPointLeave(bool down)
    {
        throw new System.NotImplementedException();
    }
}
