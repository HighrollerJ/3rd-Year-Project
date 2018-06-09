using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHandController : MonoBehaviour {
    public Animator animator;

    public Transform StartPosition;
    public Transform EndPosition;
    public float Pace;
    // Use this for initialization
    void Start () {
   
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("Turn In", true);
            this.transform.position = Vector3.MoveTowards(transform.position, EndPosition.position, Pace * Time.deltaTime);
        }
        else
        {
            animator.SetBool("Turn In", false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("Turn Out", true);
            this.transform.position = Vector3.MoveTowards(transform.position, StartPosition.position, Pace * Time.deltaTime);
        }
        else
        {
            animator.SetBool("Turn Out", false);
        }
    }
}
