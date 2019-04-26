using System;
using UnityEngine;
using UnityEngine.XR.MagicLeap;

public class scr : MonoBehaviour {
    private MLInputController _controller;
    private ComboRaycastHead head;
    public AudioSource MusicSource;

    public GameObject RayIndicator;
    private bool playingMelody = false;

    private void Start()
    {
        MLInput.Start(); // to start receiving input from the controller
        _controller = MLInput.GetController(MLInput.Hand.Left); //left or right it doesn’t really matter
        Debug.Log("Starting...");
        //MusicSource.Play();
        MusicSource.loop = true;
    }

    private void OnButtonDown(byte controllerID, MLInputControllerButton button)
    {
        Debug.Log("Button has been pressed!");
        RaycastHit hit;
        if (Physics.Raycast(_controller.Position, _controller.Orientation * Vector3.forward, out hit))
        {
            hit.collider.gameObject.GetComponent<RaycastHitHandler>().OnPoint(true);
            Debug.Log("Object Hit! " + hit.collider.name);
        }
    }

    private void OnDestroy()
    {
        MLInput.Stop();
    }

    private RaycastHitHandler lastHovered = null;

    private void Update()
    {
        RayIndicator.transform.position = _controller.Position;
        RayIndicator.transform.rotation = _controller.Orientation;
        RaycastHit hit;
        RaycastHitHandler handler = null;
        if (Physics.Raycast(_controller.Position, _controller.Orientation * Vector3.forward, out hit))
        {
            handler = hit.collider.gameObject.GetComponent<RaycastHitHandler>();
        }
        try {
            if (handler != null) {
                handler.OnPoint(_controller.TriggerValue > .1f);
                if (!System.Object.ReferenceEquals(lastHovered, handler)) {
                    if (lastHovered != null) lastHovered.OnPointLeave(_controller.TriggerValue > .1f);
                    handler.OnPointEnter(_controller.TriggerValue > .1f);
                }
            } else {
                if (lastHovered != null) lastHovered.OnPointLeave(_controller.TriggerValue > .1f);
            }
        } catch (System.NotImplementedException e) {
            Debug.LogError(e);
        }

        lastHovered = handler;
    }
}
