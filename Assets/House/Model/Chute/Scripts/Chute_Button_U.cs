using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chute_Button_U : MonoBehaviour {
    public Transform EndPosition;

    public Transform Chute;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Chute.transform.position.y == EndPosition.transform.position.y)
        {
            GameObject.Find("Chute").GetComponent<Laundry_Chute>().enabled = true;
            GameObject.Find("Chute").GetComponent<Laundry_Chute>().GoUp = true;
            GameObject.Find("ButtonUp").GetComponent<Chute_Button_U>().enabled = false;
        }
        
    }
}
