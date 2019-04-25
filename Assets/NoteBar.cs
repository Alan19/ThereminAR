using System;
using UnityEngine;

public class NoteBar : MonoBehaviour, RaycastHitHandler {
    public Renderer rend;
    public AudioSource MusicSource;
    public bool playing;
    public int notePosition;
    public String note;

    public void OnPoint(bool down)
    {
        if (down && playing == false)
        {
            MusicSource.Play();
        }
        else if(!down && playing)
        {
            MusicSource.Stop();
        }
    }

    public void OnPointEnter(bool down)
    {
        rend.enabled = true;
        if (down && playing == false)
        {
            MusicSource.Play();
        }
        else if (!down && playing)
        {
            MusicSource.Stop();
        }
    }

    public void OnPointLeave(bool down)
    {
        rend.enabled = false;
        MusicSource.Stop();
    }

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        MusicSource.clip = scr.notes[notePosition];
        playing = false;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
