using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.MagicLeap;

public class Scr : MonoBehaviour {
    private MLInputController _controller;
    public GameObject tempoBox;
    private GameObject instrumentToggle;
    private GameObject currentNote;
    private GameObject metronomeButton;
    int tempo = 0;
    string key = "A";
    private GameObject _cube;
    private bool _bumper;
    private bool _enabled;
    private int _rotationSpeed;
    private Vector3 _moveSpeed;
    private Vector3 _distance;

    //Vectors that describe where the controller is pointing to
    private Vector3 forward;
    private Vector3 right;
    private Vector3 force;

    void Awake()
    {
        _cube = GameObject.Find("Cube");
        _cube.SetActive(false);
        MLInput.Start();
        MLInput.OnControllerButtonDown += OnButtonDown;
        MLInput.OnControllerButtonUp += OnButtonUp;
        _controller = MLInput.GetController(MLInput.Hand.Left);
    }

    void OnDestroy()
    {
        MLInput.OnControllerButtonDown -= OnButtonDown;
        MLInput.OnControllerButtonUp -= OnButtonUp;
        MLInput.Stop();
    }

    void Update()
    {
        if (!_bumper && _enabled)
        {
        }
        CheckControl();
    }

    void CheckControl()
    {
        if (_controller.TriggerValue > 0.2f && _enabled)
        {
            _bumper = false;
            _cube.transform.Rotate(Vector3.up, -_rotationSpeed * Time.deltaTime);
        }
        else if (_controller.Touch1PosAndForce.z > 0.0f && _enabled)
        {
            float X = _controller.Touch1PosAndForce.x;
            float Y = _controller.Touch1PosAndForce.y;
            forward = Vector3.Normalize(Vector3.ProjectOnPlane(transform.forward, Vector3.up));
            right = Vector3.Normalize(Vector3.ProjectOnPlane(transform.right, Vector3.up));
            force = Vector3.Normalize((X * right) + (Y * forward));
        }
    }

    void OnButtonDown(byte controller_id, MLInputControllerButton button)
    {

    }

    void OnButtonUp(byte controller_id, MLInputControllerButton button)
    {
    }

    // Use this for initialization
    void Start () {
        tempoBox = GameObject.Find("Cube");
        instrumentToggle = GameObject.Find("Cube (1)");
        currentNote = GameObject.Find("Cube (2)");
        metronomeButton = GameObject.Find("Cylinder");
    }
	}
