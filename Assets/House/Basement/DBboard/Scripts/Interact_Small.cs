using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact_Small : MonoBehaviour {
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            bool didHit = Physics.Raycast(ray, out hit, 2000f);

            if (didHit)
            {
                Small_Breaker breaker = hit.collider.GetComponent<Small_Breaker>();
                if (breaker)
                {
                    if (breaker.gameObject.tag == "PB_Bed_Top")
                    {
                        GameObject.Find("Game_Manager").GetComponent<Game_Controller>().PlugsBedrooms = GameObject.Find("P_Bed").GetComponent<Small_Breaker>().ChangeBreakerState();
                    }
                    else if (breaker.gameObject.tag == "LB_Bed_Top")
                    {
                        GameObject.Find("Game_Manager").GetComponent<Game_Controller>().LightsBedrooms = GameObject.Find("L_Bed").GetComponent<Small_Breaker>().ChangeBreakerState();
                    }

                }
            }
        }
    }
}
