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
        Debug.Log("Button has been pressed!");
        RaycastHit hit;
        MusicSource.Play();
        if (Physics.Raycast(_controller.Position, transform.forward, out hit))
        {
            Debug.Log("Object Hit!");
            //Debug.DrawRay(hit.point, hit.normal, Color.blue);
            if (button == MLInputControllerButton.Bumper)
            {
                Debug.Log("started");
                Debug.Log("Object Hit!");
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
        Vector3 forward = transform.forward * 10;
        GameObject myLine = new GameObject();
        myLine.transform.position = transform.position;
        myLine.AddComponent<LineRenderer>();
        LineRenderer lr = myLine.GetComponent<LineRenderer>();
        lr.material = new Material(Shader.Find("Particles/Alpha Blended Premultiply"));
        lr.SetPosition(0, transform.position);
        lr.SetPosition(1, transform.forward * 10);
        GameObject.Destroy(myLine, 0);

    }
}
