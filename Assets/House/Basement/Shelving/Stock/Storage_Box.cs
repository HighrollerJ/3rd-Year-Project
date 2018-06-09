using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storage_Box : MonoBehaviour {
    //Focus-Point
    public GameObject focus_Point;
    public Camera mainCam;
    // Use this for initialization
    void Start()
    {
        CameraPosition(focus_Point);
    }

    // Update is called once per frame
    void Update()
    {
        CameraPosition(focus_Point);
        
    }
    public void CameraPosition(GameObject camPos)
    {
        GameObject.Find("Main Camera").GetComponent<CameraCollision>().enabled = false;
        mainCam.transform.position = camPos.transform.position;
        mainCam.transform.rotation = camPos.transform.rotation;
    }
}
