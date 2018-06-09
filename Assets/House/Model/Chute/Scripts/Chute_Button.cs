using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chute_Button : MonoBehaviour {
    public Transform StartPosition;
    public Transform Chute;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Chute.transform.position.y == StartPosition.transform.position.y)
        {
            GameObject.Find("Chute").GetComponent<Laundry_Chute>().enabled = true;
            GameObject.Find("Chute").GetComponent<Laundry_Chute>().GoDown = true;

            GameObject.Find("ButtonDown").GetComponent<Chute_Button>().enabled = false;
        }
    }
}
