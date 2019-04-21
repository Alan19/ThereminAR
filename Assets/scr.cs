using System;
using UnityEngine;
using UnityEngine.XR.MagicLeap;

public class scr : MonoBehaviour {
    private MLInputController _controller;
    private ComboRaycastHead head;
    public AudioSource MusicSource;
    public AudioClip MusicClip;
    public TextMesh note;

    public GameObject RayIndicator;
    private bool playingMelody = false;

    private void Start()
    {

        MLInput.Start(); // to start receiving input from the controller
        MLInput.OnTriggerUp += OnTriggerUp; // a listener function that listens for the button input.
        MLInput.OnTriggerDown += OnTriggerDown;
        _controller = MLInput.GetController(MLInput.Hand.Left); //left or right it doesn’t really matter
        Debug.Log("Starting...");
        //MusicSource.Play();
    }

    private void OnTriggerDown(byte controller_id, float triggerVal)
    {
        Debug.Log("Button has been pressed!");
        RaycastHit hit;
        if (Physics.Raycast(_controller.Position, _controller.Orientation * Vector3.forward, out hit))
        {
            hit.collider.gameObject.GetComponent<RaycastHitHandler>().HandleRaycastHit(hit);
            Debug.Log("Object Hit! " + hit.collider.name);
            if (triggerVal > .1f && hit.collider.gameObject.name.Equals("PlayableArea"))
            {
                MusicSource.clip = MusicClip;
                MusicSource.Play();
                playingMelody = true;
                if (note != null)
                {
                    note.text = "C";
                }
            }
        }
    }

    private void OnTriggerUp(byte controller_id, float triggerVal)
    {
        if (playingMelody)
        {
            MusicSource.Stop();
            playingMelody = false;
        }
        if (note != null) note.text = "";
    }

    void OnButtonUp(byte controller_id, MLInputControllerButton button)
    {
        if (playingMelody)
        {
            MusicSource.Stop();
            playingMelody = false;
        }
        if (note != null) note.text = "";
    }


    private void OnButtonDown(byte controllerID, MLInputControllerButton button)
    {
        Debug.Log("Button has been pressed!");
        RaycastHit hit;
        if (Physics.Raycast(_controller.Position, _controller.Orientation * Vector3.forward, out hit))
        {
            hit.collider.gameObject.GetComponent<RaycastHitHandler>().HandleRaycastHit(hit);
            Debug.Log("Object Hit! " + hit.collider.name);
            if (_controller.TriggerValue > .1f && hit.collider.gameObject.name.Equals("PlayableArea"))
            {
                MusicSource.clip = MusicClip;
                MusicSource.Play();
                playingMelody = true;
                if (note != null)
                {
                    note.text = "C";
                }
            }
        }
    }


    private void OnDestroy()
    {
        MLInput.Stop();
        MLInput.OnTriggerDown -= OnTriggerDown;
    }

    private void Update()
    {
        RayIndicator.transform.position = _controller.Position;
        RayIndicator.transform.rotation = _controller.Orientation;
        Debug.Log("Button has been pressed!");
        RaycastHit hit;
        if (Physics.Raycast(_controller.Position, _controller.Orientation * Vector3.forward, out hit))
        {
            hit.collider.gameObject.GetComponent<RaycastHitHandler>().HandleRaycastHover(hit);
        }
    }
}
