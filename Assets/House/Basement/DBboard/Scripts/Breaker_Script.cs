using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breaker_Script : MonoBehaviour {
    public bool on = true;
    public float leverOnAngle;
    public float leverOffAngle;
    public GameObject lever;

    public float smooth = 8f;
    // Use this for initialization
    void Start()
    {

    }

    public bool ChangeBreakerState()
    {
        on = !on;
        return on;
    }

    // Update is called once per frame
    void Update()
    {
        if (on)
        {
            if (gameObject.tag == "Breaker")
            {
                GameObject.Find("Game_Manager").GetComponent<Game_Controller>().EarthLeakageTop = on;
            }

            Quaternion targetRotation = Quaternion.Euler(leverOnAngle, 0, 0);
            transform.localRotation = Quaternion.Slerp(lever.transform.localRotation, targetRotation, smooth * Time.deltaTime);
        }
        else
        {
            if (gameObject.tag == "Breaker")
            {
                GameObject.Find("Game_Manager").GetComponent<Game_Controller>().EarthLeakageTop = on;
            }

            Quaternion targetRotation2 = Quaternion.Euler(leverOffAngle, 0, 0);
            transform.localRotation = Quaternion.Slerp(lever.transform.localRotation, targetRotation2, smooth * Time.deltaTime);
        }
    }
}
