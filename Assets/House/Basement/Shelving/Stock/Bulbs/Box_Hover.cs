using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box_Hover : MonoBehaviour {
    public GameObject Gui;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseEnter()
    {
        Gui.GetComponent<Canvas>().enabled = true;
    }
    private void OnMouseExit()
    {
        Gui.GetComponent<Canvas>().enabled = false;
    }
}
