using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_Interact : MonoBehaviour {

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
                Light_Switch breaker = hit.collider.GetComponent<Light_Switch>();
                if (breaker)
                {
                    GameObject.Find(hit.collider.name).GetComponent<Light_Switch>().ChangeLightState();
                }

                Socket_Switch socket = hit.collider.GetComponent<Socket_Switch>();
                if(socket)
                {
                    GameObject.Find(hit.collider.name).GetComponent<Socket_Switch>().ChangeSocketState();
                }
            }
        }
    }
}
