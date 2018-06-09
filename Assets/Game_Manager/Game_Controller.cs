using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Controller : MonoBehaviour {
    //DBBoard
    //Top Floor
    public bool EarthLeakageTop;

    public bool LightsBedrooms;
    public bool LightsBathrooms;
    public bool LightsLiving;

    public bool PlugsBedrooms;
    public bool PlugsBathrooms;
    public bool PlugsLiving;
    //Middle Floor
    //Basement


    // Use this for initialization
    void Start () {
        //GameObject.Find("Lever").GetComponent<Breaker_Script>().on = EarthLeakageTop;
        if (EarthLeakageTop)
        {
            GameObject.Find("L_Bed").GetComponent<Small_Breaker>().power = true;
            GameObject.Find("L_Bath").GetComponent<Small_Breaker>().power = true;
            GameObject.Find("L_Live").GetComponent<Small_Breaker>().power = true;

            GameObject.Find("P_Bed").GetComponent<Small_Breaker>().power = true;
            GameObject.Find("P_Bath").GetComponent<Small_Breaker>().power = true;
            GameObject.Find("P_Live").GetComponent<Small_Breaker>().power = true;
        }
        else
        {
            GameObject.Find("L_Bed").GetComponent<Small_Breaker>().power = false;
            GameObject.Find("L_Bath").GetComponent<Small_Breaker>().power = false;
            GameObject.Find("L_Live").GetComponent<Small_Breaker>().power = false;

            GameObject.Find("P_Bed").GetComponent<Small_Breaker>().power = false;
            GameObject.Find("P_Bath").GetComponent<Small_Breaker>().power = false;
            GameObject.Find("P_Live").GetComponent<Small_Breaker>().power = false;
        }

        GameObject.Find("L_Bed").GetComponent<Small_Breaker>().on = LightsBedrooms;
        GameObject.Find("L_Bath").GetComponent<Small_Breaker>().on = LightsBathrooms;
        GameObject.Find("L_Live").GetComponent<Small_Breaker>().on = LightsLiving;

        GameObject.Find("P_Bed").GetComponent<Small_Breaker>().on = PlugsBedrooms;
        GameObject.Find("P_Bath").GetComponent<Small_Breaker>().on = PlugsBathrooms;
        GameObject.Find("P_Live").GetComponent<Small_Breaker>().on = PlugsLiving;
    }
	
	// Update is called once per frame
	void Update () {
        if (EarthLeakageTop)
        {
            GameObject.Find("L_Bed").GetComponent<Small_Breaker>().power = true;
            GameObject.Find("L_Bath").GetComponent<Small_Breaker>().power = true;
            GameObject.Find("L_Live").GetComponent<Small_Breaker>().power = true;

            GameObject.Find("P_Bed").GetComponent<Small_Breaker>().power = true;
            GameObject.Find("P_Bath").GetComponent<Small_Breaker>().power = true;
            GameObject.Find("P_Live").GetComponent<Small_Breaker>().power = true;
        }
        else
        {
            GameObject.Find("L_Bed").GetComponent<Small_Breaker>().power = false;
            GameObject.Find("L_Bath").GetComponent<Small_Breaker>().power = false;
            GameObject.Find("L_Live").GetComponent<Small_Breaker>().power = false;

            GameObject.Find("P_Bed").GetComponent<Small_Breaker>().power = false;
            GameObject.Find("P_Bath").GetComponent<Small_Breaker>().power = false;
            GameObject.Find("P_Live").GetComponent<Small_Breaker>().power = false;
        }
        GameObject.Find("L_Bed").GetComponent<Small_Breaker>().on = LightsBedrooms;
        GameObject.Find("P_Bed").GetComponent<Small_Breaker>().on = PlugsBedrooms;
    }
}
