using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulb_State : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("Lever").GetComponent<Socket_Switch>().power == true)
        {
            if (GameObject.Find("Lever").GetComponent<Socket_Switch>().on == true)
            {
                if (GameObject.Find("Bulb_Screw_In").GetComponent<Bulb_Rotation>().Broken == false)
                {
                    if (GameObject.Find("Bulb_Screw_In").GetComponent<Bulb_Rotation>().TurnedIn == true)
                    {
                        GameObject.Find("Bulb_Screw_In").GetComponent<Light>().enabled = true;
                    }
                    else
                    {
                        GameObject.Find("Bulb_Screw_In").GetComponent<Light>().enabled = false;
                    }
                }
                else
                {
                    GameObject.Find("Bulb_Screw_In").GetComponent<Light>().enabled = false;
                }
            }
            else
            {
                GameObject.Find("Bulb_Screw_In").GetComponent<Light>().enabled = false;
            }
        }
        else
        {
            GameObject.Find("Bulb_Screw_In").GetComponent<Light>().enabled = false;
        }
    }
}
