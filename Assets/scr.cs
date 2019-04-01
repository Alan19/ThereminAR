using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.MagicLeap;

public class scr : MonoBehaviour {

    private MLInputController _controller;
    public GameObject tempoBox;
    private GameObject instrumentToggle;
    private GameObject currentNote;
    private GameObject metronomeButton;
    int tempo = 0;
    string key = "A";

	// Use this for initialization
	void Start () {
        tempoBox = GameObject.Find("Cube");
        instrumentToggle = GameObject.Find("Cube (1)");
        currentNote = GameObject.Find("Cube (2)");
        metronomeButton = GameObject.Find("Cylinder");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
