using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBboard_Script : MonoBehaviour {
    public bool lockCursor;

    //Focus-Point
    public GameObject focus_Point;
    public Camera mainCam;
    // Use this for initialization
    void Start () {
        CameraPosition(focus_Point);
    }
	
	// Update is called once per frame
	void Update () {
        CameraPosition(focus_Point);
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GameObject.Find("DB_Board").GetComponent<DBboard_Script>().enabled = false;
            GameObject.Find("Main Camera").GetComponent<CameraCollision>().enabled = true;
            GameObject.Find("Main_Character").GetComponent<CharacterController>().enabled = true;
            GameObject.Find("Main_Character").GetComponent<CharacterControl>().enabled = true;
            GameObject.Find("DB_Board").GetComponent<Collider>().enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
    public void CameraPosition(GameObject camPos)
    {
        GameObject.Find("Main Camera").GetComponent<CameraCollision>().enabled = false;
        mainCam.transform.position = camPos.transform.position;
        mainCam.transform.rotation = camPos.transform.rotation;
        if (!lockCursor)
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
