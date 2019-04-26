using System;
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
    public double buttonCooldown = 1.0f;
    public double tempoCoolDown;
    public double tickCooldown;


    public void HandleRaycastHit(RaycastHit rh)
    {
    }

    // Use this for initialization
    void Start () {
        tempoCoolDown = 1f/(Int32.Parse(Settings.getSetting("tempo"))/60.0f);
        tickCooldown = tempoCoolDown;
    }

    // Update is called once per frame
    void Update () {
        tempoCoolDown = 1f / (Int32.Parse(Settings.getSetting("tempo")) / 60.0f);
        buttonCooldown -= Time.deltaTime;
        tickCooldown -= Time.deltaTime;
        if (on && tickCooldown < 0)
        {
            MusicSource.Play();
            tickCooldown = tempoCoolDown;
        }
        else if (!on)
        {
            MusicSource.Stop();
        }
	}

    public void OnPointEnter(bool down)
    {
        throw new System.NotImplementedException();
    }

    public void OnPoint(bool down)
    {
        MusicSource.clip = MusicClip;
        if(buttonCooldown < 0)
        {
            if (on && down)
            {
                on = false;
                rend.material = originalMat;
                buttonCooldown = 1.0f;

            }
            else if (!on && down)
            {
                on = true;
                rend.material = enableMat;
                buttonCooldown = 1.0f;

            }

        }

    }

    public void OnPointLeave(bool down)
    {
        throw new System.NotImplementedException();
    }
}
