using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeField : MonoBehaviour, RaycastHitHandler {

    public int amount;
    public string fieldToChange;
    private bool toggled = false;
    private float cooldown = 0.1f;

    public void OnPoint(bool down)
    {
        if (down)
        {
            if(cooldown < 0)
            {
                Settings.changeSetting(fieldToChange, amount);
                cooldown = 0.1f;
            }
            
        }
    }

    public void OnPointEnter(bool down)
    {
    }

    public void OnPointLeave(bool down)
    {
        throw new System.NotImplementedException();
    }



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        cooldown -= Time.deltaTime;
	}
}
