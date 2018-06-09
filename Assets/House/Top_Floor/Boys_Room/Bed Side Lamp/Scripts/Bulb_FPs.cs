using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulb_FPs : MonoBehaviour {
    //MoveCameraTowardsTargetPoint
    public float moveSpeed = 35.0f;
    public GameObject targetPosition;
    public GameObject Arms;
    private bool movingTowardsTarget = false;

    //Rotating Camera to view of focus_point
    private float lerpSpeed = 0.025f;
    private Transform fromRotation;
    private Transform toRotation;
    private bool inPosition = false;

    // Use this for initialization
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (movingTowardsTarget == true)
        {
            movingTowardsTarget = false;
        }
        else
        {
            fromRotation = gameObject.transform;
            toRotation = targetPosition.transform;
            movingTowardsTarget = true;
        }

        if (movingTowardsTarget)
        {
            MoveTowardsTarget(targetPosition);
        }
    }

    public void MoveTowardsTarget(GameObject target)
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target.transform.position) < 0.1)
        {
            transform.position = target.transform.position;
            inPosition = true;

            if (inPosition)
            {
                transform.rotation = toRotation.rotation;

                Arms.SetActive(true);
            }

            movingTowardsTarget = false;
            if(fromRotation.rotation == toRotation.rotation)
            {
                GameObject.Find("Main Camera").GetComponent<Bulb_FPs>().enabled = false;
            }            
        }
    }
}
