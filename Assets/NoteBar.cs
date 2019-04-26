using System;
using UnityEngine;

public class NoteBar : MonoBehaviour, RaycastHitHandler {
    public Renderer rend;
    private MusicHolder holder;
    private AudioClip thisClip;
    public AudioSource MusicSource;
    public bool playing;
    public int notePosition;
    public String note;
    public GameObject musicObject;

    public void OnPoint(bool down)
    {
        Settings.Note = note;
        MusicSource.clip = holder.GetClip(notePosition); ;
        if (down && !playing)
        {
            MusicSource.Play();
            playing = true;
        }
        else if(!down && playing)
        {
            MusicSource.Stop();
            playing = false;
        }
    }

    public void OnPointEnter(bool down)
    {
        rend.enabled = true;
    }

    public void OnPointLeave(bool down)
    {
        rend.enabled = false;
        if (MusicSource.clip.Equals(thisClip)) MusicSource.Stop();
        Settings.Note = "";
        playing = false;
    }

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        holder = musicObject.GetComponent<MusicHolder>();
        thisClip = holder.GetClip(notePosition);
        Debug.Log(thisClip);

        playing = false;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
