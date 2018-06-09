using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Switch : MonoBehaviour {
    public bool on;
    public float leverOnAngle;
    public float leverOffAngle;
    public GameObject lever;

    public float smooth = 8f;
    public Material material;
    // Use this for initialization
    void Start()
    {

    }

    public void ChangeLightState()
    {
        on = !on;
    }

    // Update is called once per frame
    void Update()
    {
        if (on)
        {
            Quaternion targetRotation = Quaternion.Euler(-90.00001f, leverOnAngle, 6.372f);
            transform.localRotation = Quaternion.Slerp(lever.transform.localRotation, targetRotation, smooth * Time.deltaTime);

            //Check if lights breaker is on and Earth Leakage is on
            if(GameObject.Find("Game_Manager").GetComponent<Game_Controller>().EarthLeakageTop == true && GameObject.Find("Game_Manager").GetComponent<Game_Controller>().LightsBedrooms == true)
            {
                GameObject.Find("Light_One").GetComponent<Light>().enabled = true;
                GameObject.Find("Light_Two").GetComponent<Light>().enabled = true;
                GameObject.Find("Light_Three").GetComponent<Light>().enabled = true;

                material.EnableKeyword("_EMISSION");
            }
            else
            {
                GameObject.Find("Light_One").GetComponent<Light>().enabled = false;
                GameObject.Find("Light_Two").GetComponent<Light>().enabled = false;
                GameObject.Find("Light_Three").GetComponent<Light>().enabled = false;

                material.DisableKeyword("_EMISSION");
            }
        }
        else
        {
            Quaternion targetRotation2 = Quaternion.Euler(-90.00001f, leverOffAngle, 6.372f);
            transform.localRotation = Quaternion.Slerp(lever.transform.localRotation, targetRotation2, smooth * Time.deltaTime);
            GameObject.Find("Light_One").GetComponent<Light>().enabled = false;
            GameObject.Find("Light_Two").GetComponent<Light>().enabled = false;
            GameObject.Find("Light_Three").GetComponent<Light>().enabled = false;

            material.DisableKeyword("_EMISSION");
        }
    }
}
