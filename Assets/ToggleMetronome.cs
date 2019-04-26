using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMetronome : MonoBehaviour, RaycastHitHandler {
    bool on = false;
    public AudioSource MusicSource;
    public AudioClip MusicClip;
    public Material enableMat;
    public Material originalMat;
    public Renderer rend;
    public double cooldown = 1.0f;


    public void HandleRaycastHit(RaycastHit rh)
    {
    }

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {
        cooldown -= Time.deltaTime;
	}

    public void OnPointEnter(bool down)
    {
        throw new System.NotImplementedException();
    }

    public void OnPoint(bool down)
    {
        MusicSource.clip = MusicClip;
        if(cooldown < 0)
        {
            if (on && down)
            {
                on = false;
                MusicSource.Stop();
                rend.material = originalMat;
                cooldown = 1.0f;

            }
            else if (!on && down)
            {
                on = true;
                MusicSource.Play();
                rend.material = enableMat;
                cooldown = 1.0f;
            }

        }

    }

    public void OnPointLeave(bool down)
    {
        throw new System.NotImplementedException();
    }
}
