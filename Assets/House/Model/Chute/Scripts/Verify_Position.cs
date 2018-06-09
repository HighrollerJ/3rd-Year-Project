using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verify_Position : MonoBehaviour {
    public Transform StartPosition;
    public Transform EndPosition;
    public Transform Character;

    //Camera Positions
    public Camera mainCam;
    public GameObject TopCam;
    public GameObject BasementCam;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Character.transform.position.y >= StartPosition.transform.position.y || Character.transform.position.y <= EndPosition.transform.position.y)
        {
            GameObject.Find("Main Camera").GetComponent<CameraCollision>().enabled = true;

            GameObject.Find("Main_Character").GetComponent<CharacterControl>().walkSpeed = 4;
            GameObject.Find("Main_Character").GetComponent<CharacterControl>().runSpeed = 8;

            
        }
        if (Character.transform.position.y < StartPosition.transform.position.y && Character.transform.position.y > EndPosition.transform.position.y)
        {
            GameObject.Find("Chute").GetComponent<Verify_Position>().enabled = true;
            GameObject.Find("Main Camera").GetComponent<CameraCollision>().enabled = false;

            GameObject.Find("Main_Character").GetComponent<CharacterControl>().walkSpeed = 0.1f;
            GameObject.Find("Main_Character").GetComponent<CharacterControl>().runSpeed = 0.1f;

            if (GameObject.Find("Chute").GetComponent<Laundry_Chute>().GoDown == true)
            {
                CameraPosition(BasementCam);
            }
            if (GameObject.Find("Chute").GetComponent<Laundry_Chute>().GoUp == true)
            {
                CameraPosition(TopCam);
            }
        }
    }

    public void CameraPosition(GameObject camPos)
    {
        GameObject.Find("Main Camera").GetComponent<CameraCollision>().enabled = false;
        mainCam.transform.position = camPos.transform.position;
        mainCam.transform.rotation = camPos.transform.rotation;

        GameObject.Find("Chute").GetComponent<Laundry_Chute>().GoDown = false;
        GameObject.Find("Chute").GetComponent<Laundry_Chute>().GoUp = false;
    }
}
