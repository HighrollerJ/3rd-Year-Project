using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Day_Night : MonoBehaviour {
    public float timeOfDay;
    public Transform sunTransform;
    public Light Sun;

    public float ambientIntensity;
    public float intensity;

    private void LateUpdate()
    {
        RenderSettings.ambientIntensity = ambientIntensity;
        float time = timeOfDay * 60 * 60;
        ChangeTime(time);
    }

    public void ChangeTime(float time)
    {
        sunTransform.rotation = Quaternion.Euler(new Vector3((time - 21600) / 86400 * 360, 0, 0));
      
        if(time < 43200)
        {
            intensity = 1 - (43200 - time) / 43200;
            switch (time.ToString())
            {
                case "18000":
                    GameObject.Find("Light_One").GetComponent<Light>().intensity = 0.7f;
                    GameObject.Find("Light_Two").GetComponent<Light>().intensity = 0.7f;
                    GameObject.Find("Light_Three").GetComponent<Light>().intensity = 0.7f;
                    break;
                case "21600":
                    RenderSettings.ambientIntensity = 0.5f;
                    GameObject.Find("Light_One").GetComponent<Light>().intensity = 0.2f;
                    GameObject.Find("Light_Two").GetComponent<Light>().intensity = 0.2f;
                    GameObject.Find("Light_Three").GetComponent<Light>().intensity = 0.2f;
                    break;
                case "28800":
                    RenderSettings.ambientIntensity = 1;
                    GameObject.Find("Light_One").GetComponent<Light>().intensity = 0.2f;
                    GameObject.Find("Light_Two").GetComponent<Light>().intensity = 0.2f;
                    GameObject.Find("Light_Three").GetComponent<Light>().intensity = 0.2f;
                    break;
                case "36000":
                    RenderSettings.ambientIntensity = 1.5f;
                    GameObject.Find("Light_One").GetComponent<Light>().intensity = 0.2f;
                    GameObject.Find("Light_Two").GetComponent<Light>().intensity = 0.2f;
                    GameObject.Find("Light_Three").GetComponent<Light>().intensity = 0.2f;
                    break;
            }
        }
        else
        {
            intensity = 1 - ((43200 - time) / 43200 *-1);
            switch (time.ToString())
            {
                case "43200":
                    RenderSettings.ambientIntensity = 2f;
                    GameObject.Find("Light_One").GetComponent<Light>().intensity = 0.2f;
                    GameObject.Find("Light_Two").GetComponent<Light>().intensity = 0.2f;
                    GameObject.Find("Light_Three").GetComponent<Light>().intensity = 0.2f;
                    break;
                case "50400":
                    RenderSettings.ambientIntensity = 1.5f;
                    GameObject.Find("Light_One").GetComponent<Light>().intensity = 0.2f;
                    GameObject.Find("Light_Two").GetComponent<Light>().intensity = 0.2f;
                    GameObject.Find("Light_Three").GetComponent<Light>().intensity = 0.2f;
                    break;
                case "57600":
                    RenderSettings.ambientIntensity = 1;
                    GameObject.Find("Light_One").GetComponent<Light>().intensity = 0.2f;
                    GameObject.Find("Light_Two").GetComponent<Light>().intensity = 0.2f;
                    GameObject.Find("Light_Three").GetComponent<Light>().intensity = 0.2f;
                    break;
                case "61200":
                    RenderSettings.ambientIntensity = 0.5f;
                    GameObject.Find("Light_One").GetComponent<Light>().intensity = 0.7f;
                    GameObject.Find("Light_Two").GetComponent<Light>().intensity = 0.7f;
                    GameObject.Find("Light_Three").GetComponent<Light>().intensity = 0.7f;
                    break;
                case "64800":
                    RenderSettings.ambientIntensity = 0.5f;
                    GameObject.Find("Light_One").GetComponent<Light>().intensity = 1.3f;
                    GameObject.Find("Light_Two").GetComponent<Light>().intensity = 1.3f;
                    GameObject.Find("Light_Three").GetComponent<Light>().intensity = 1.3f;
                    break;
                case "72000":
                    RenderSettings.ambientIntensity = 0f;
                    GameObject.Find("Light_One").GetComponent<Light>().intensity = 1.3f;
                    GameObject.Find("Light_Two").GetComponent<Light>().intensity = 1.3f;
                    GameObject.Find("Light_Three").GetComponent<Light>().intensity = 1.3f;
                    break;
            }
        }

        Sun.intensity = intensity;
    }
}
