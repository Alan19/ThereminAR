using System;
using UnityEngine;

public class NoteBar : RaycastHitHandler {
    public Renderer rend;
    public AudioSource MusicSource;
    public bool playing;
    public int notePosition;
    public String note;

    public override void OnPoint(bool down)
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

    public override void OnPointEnter(bool down)
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

    public override void OnPointLeave(bool down)
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
