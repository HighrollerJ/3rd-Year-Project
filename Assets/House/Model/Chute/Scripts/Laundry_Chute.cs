using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laundry_Chute : MonoBehaviour {
    public Animator animator;
    public bool GoDown;
    public bool GoUp;

	// Use this for initialization
	void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {
        if (GoDown)
        {
            GoUp = false;
            animator.SetBool("GoDown", GoDown);
            animator.SetBool("GoUp", GoUp);
            GameObject.Find("Chute").GetComponent<Laundry_Chute>().enabled = false;
        }

        if (GoUp)
        {
            GoDown = false;
            animator.SetBool("GoUp", GoUp);
            animator.SetBool("GoDown", GoDown);
            GameObject.Find("Chute").GetComponent<Laundry_Chute>().enabled = false;
        }
    }
}
