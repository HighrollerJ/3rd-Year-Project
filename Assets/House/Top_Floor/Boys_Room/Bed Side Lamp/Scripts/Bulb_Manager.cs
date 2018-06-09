using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulb_Manager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }

        if(GameObject.Find("Bulb_Screw_In").GetComponent<MeshRenderer>().enabled)
        {
            GameObject.Find("Bulb_Screw_In").GetComponent<Bulb_Rotation>().enabled = true;
            GameObject.Find("RH_Bulb_Screw_In").GetComponent<RightHandController>().enabled = true;
        }
        else if (GameObject.Find("Bulb_Bayonette").GetComponent<MeshRenderer>().enabled)
        {
            GameObject.Find("Bulb_Screw_In").GetComponent<Bulb_Rotation>().enabled = false;
            GameObject.Find("RH_Bulb_Screw_In").GetComponent<RightHandController>().enabled = false;
        }
    }
}
