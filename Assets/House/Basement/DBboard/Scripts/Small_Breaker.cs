using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Small_Breaker : MonoBehaviour {
    public bool power;
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
            if (gameObject.tag == "LB_Bed_Top")
            {
                GameObject.Find("Game_Manager").GetComponent<Game_Controller>().LightsBedrooms = on;
            }
            else if (gameObject.tag == "PB_Bed_Top")
            {
                GameObject.Find("Game_Manager").GetComponent<Game_Controller>().PlugsBedrooms = on;
            }

            Quaternion targetRotation = Quaternion.Euler(0, -90, leverOnAngle);
            transform.localRotation = Quaternion.Slerp(lever.transform.localRotation, targetRotation, smooth * Time.deltaTime);
        }
        else
        {
            if (gameObject.tag == "LB_Bed_Top")
            {
                GameObject.Find("Game_Manager").GetComponent<Game_Controller>().LightsBedrooms = on;
            }
            else if (gameObject.tag == "PB_Bed_Top")
            {
                GameObject.Find("Game_Manager").GetComponent<Game_Controller>().PlugsBedrooms = on;
            }

            Quaternion targetRotation2 = Quaternion.Euler(0, -90, leverOffAngle);
            transform.localRotation = Quaternion.Slerp(lever.transform.localRotation, targetRotation2, smooth * Time.deltaTime);
        }
    }
}
