using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicHolder : MonoBehaviour {
    
    public AudioClip[] vClip;
    public AudioClip[] pClips;

    private static AudioClip errorTune;

    public AudioClip GetClip(int notePosition)
    {
        if (Settings.Instrument.Equals("Violin"))
        {
            return vClip[notePosition];
        }
        else if (Settings.Instrument.Equals("Piano"))
        {
            return pClips[notePosition];
        }
        return errorTune;
    }
}
