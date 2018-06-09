using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact_Breaker : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            bool didHit = Physics.Raycast(ray, out hit, 2000f);
            
            if (didHit)
            {
                Breaker_Script breaker = hit.collider.GetComponent<Breaker_Script>();
                if (breaker)
                {
                    if (breaker.gameObject.tag == "Breaker")
                    {
                        GameObject.Find("Game_Manager").GetComponent<Game_Controller>().EarthLeakageTop = breaker.ChangeBreakerState();
                    } 
                }
            }
        }
    }
}
