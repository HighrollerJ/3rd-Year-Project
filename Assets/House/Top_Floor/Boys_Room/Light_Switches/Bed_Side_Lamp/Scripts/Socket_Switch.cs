using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Socket_Switch : MonoBehaviour {
    public bool power;
    public bool on;
    public float leverOnAngle;
    public float leverOffAngle;
    public GameObject lever;

    public float smooth = 10f;
    // Use this for initialization
    void Start()
    {

    }

    public void ChangeSocketState()
    {
        on = !on;
    }

    // Update is called once per frame
    void Update()
    {
        if (on)
        {
            Quaternion targetRotation = Quaternion.Euler(leverOnAngle, 90.00001f, -90.00001f);
            transform.localRotation = Quaternion.Slerp(lever.transform.localRotation, targetRotation, smooth * Time.deltaTime);

            //Check if plugs breaker is on and Earth Leakage is on
            if (GameObject.Find("Game_Manager").GetComponent<Game_Controller>().EarthLeakageTop == true && GameObject.Find("Game_Manager").GetComponent<Game_Controller>().PlugsBedrooms == true)
            {
                power = true;
            }
            else
            {
                power = false;
            }
        }
        else
        {
            Quaternion targetRotation2 = Quaternion.Euler(leverOffAngle, 90.00001f, -90.00001f);
            transform.localRotation = Quaternion.Slerp(lever.transform.localRotation, targetRotation2, smooth * Time.deltaTime);

            if (GameObject.Find("Game_Manager").GetComponent<Game_Controller>().EarthLeakageTop == true && GameObject.Find("Game_Manager").GetComponent<Game_Controller>().PlugsBedrooms == true)
            {
                power = true;
            }
            else
            {
                power = false;
            }
        }
    }
}
