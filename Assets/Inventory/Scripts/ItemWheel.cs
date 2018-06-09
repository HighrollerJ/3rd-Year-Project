using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemWheel : MonoBehaviour {
    public GameObject  itemw;
    public GameObject  item1;
    public GameObject  item2;
    public GameObject item3;
    public GameObject item4;

    public GameObject subMenuBulbs;
    public GameObject subMenuMisc;
    public GameObject subMenuTools;

    // Use this for initialization
    void Start ()
    {

        itemw.SetActive(false);
        subMenuBulbs.SetActive(false);
		subMenuMisc.SetActive(false);
		subMenuTools.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E) && GameObject.Find("Main Camera").GetComponent<CameraCollision>().enabled == true)
        {
            Cursor.lockState = CursorLockMode.None;
            itemw.SetActive(true);
            subMenuBulbs.SetActive(false);
            subMenuMisc.SetActive(false);
            subMenuTools.SetActive(false);
        }
        else if(Input.GetKeyDown(KeyCode.E) && GameObject.Find("Bed_Side_Lamp").GetComponent<Bulb_Manager>().enabled == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            itemw.SetActive(true);
            subMenuBulbs.SetActive(false);
            subMenuMisc.SetActive(false);
            subMenuTools.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.E) && GameObject.Find("Bulb_Screw_In").GetComponent<Bulb_Rotation>().enabled == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            itemw.SetActive(true);
            subMenuBulbs.SetActive(false);
            subMenuMisc.SetActive(false);
            subMenuTools.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            itemw.SetActive(false);
            subMenuBulbs.SetActive(false);
            subMenuMisc.SetActive(false);
            subMenuTools.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
        }
        else if (Input.GetKeyUp(KeyCode.E) && GameObject.Find("Bulb_Screw_In").GetComponent<MeshRenderer>().enabled == true)
        {
            itemw.SetActive(false);
            subMenuBulbs.SetActive(false);
            subMenuMisc.SetActive(false);
            subMenuTools.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }


    public void Bulb()
    {
        subMenuBulbs.SetActive(true);
        subMenuMisc.SetActive(false);
        subMenuTools.SetActive(false);
    }

    public void Misc()
    {
        subMenuBulbs.SetActive(false);
        subMenuMisc.SetActive(true);
        subMenuTools.SetActive(false);
    }

    public void Tools()
    {
        subMenuBulbs.SetActive(false);
        subMenuMisc.SetActive(false);
        subMenuTools.SetActive(true);
    }
}

