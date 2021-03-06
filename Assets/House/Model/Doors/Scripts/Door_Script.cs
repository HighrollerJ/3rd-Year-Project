﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Script : MonoBehaviour {
    public bool open = false;
    public float doorOpenAngle;
    public float doorClosedAngle;

    public float smooth = 2f;
	// Use this for initialization
	void Start () {
		
	}

    public void ChangeDoorState()
    {
        open = !open;
    }

    // Update is called once per frame
    void Update () {
		if(open)
        {
            Quaternion targetRotation = Quaternion.Euler(0, doorOpenAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
        }
        else
        {
            Quaternion targetRotation2 = Quaternion.Euler(0, doorClosedAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation2, smooth * Time.deltaTime);
        }
	}
}
