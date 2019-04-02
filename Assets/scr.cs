using System;
using UnityEngine;
using UnityEngine.XR.MagicLeap;

public class scr : MonoBehaviour {
    private MLInputController _controller;
    private ComboRaycastHead head;
    public AudioSource MusicSource;
    public AudioClip MusicClip;

    private void Start()
    {
        MLInput.Start(); // to start receiving input from the controller
        MLInput.OnControllerButtonDown += OnButtonDown; // a listener function that listens for the button input.
        MLInput.OnControllerButtonUp += OnButtonUp;
        _controller = MLInput.GetController(MLInput.Hand.Left); //left or right it doesn’t really matter
        Debug.Log("Starting...");
        MusicSource.clip = MusicClip;
        //MusicSource.Play();
    }

    void OnButtonUp(byte controller_id, MLInputControllerButton button)
    {
        MusicSource.Stop();
    }


    private void OnButtonDown(byte controllerID, MLInputControllerButton button)
    {
        Debug.DrawRay(transform.position, transform.forward, Color.green);
        Debug.Log("Button has been pressed!");
        RaycastHit hit;
        //Debug.DrawRay(_controller.Orientation * _controller.Position, transform.forward);
        Debug.DrawRay(_controller.Position, _controller.Orientation.eulerAngles, Color.red, 15.0f);
        MusicSource.Play();
        if (Physics.Raycast(_controller.Position, _controller.Orientation.eulerAngles, out hit))
        {
            Debug.Log("Object Hit!");
            Debug.Log(hit.collider.name);
            if (button == MLInputControllerButton.Bumper)
            {
                MusicSource.Play();
            }
        }
    }


    private void OnDestroy()
    {
        MLInput.Stop();
        MLInput.OnControllerButtonDown -= OnButtonDown;
    }

    private void Update()
    {
        transform.position = _controller.Position;   // a Vector3 quantity
        transform.rotation = _controller.Orientation;    // a Quaternion quantity
        //Debug.DrawRay(_controller.Position, _controller.Orientation.eulerAngles * 20, Color.yellow, .5f);
        /*
        GameObject myLine = new GameObject();
        myLine.transform.position = transform.position;
        myLine.AddComponent<LineRenderer>();
        LineRenderer lr = myLine.GetComponent<LineRenderer>();
        lr.material = new Material(Shader.Find("Particles/Alpha Blended Premultiply"));
        lr.startWidth = .1f;
        lr.endWidth = .1f;
        //Debug.Log(_controller.Position);
        lr.SetPosition(0, _controller.Orientation * _controller.Position);
        lr.SetPosition(1, transform.forward * 20);
        GameObject.Destroy(myLine, .1f);
        */
        Debug.DrawRay(_controller.Position, _controller.Orientation.eulerAngles, Color.red, 15.0f);
    }
}
