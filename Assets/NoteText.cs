using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteText : MonoBehaviour {

    public TextMesh text;
    public string setting;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        text.text = Settings.getSetting(setting);
    }
}
