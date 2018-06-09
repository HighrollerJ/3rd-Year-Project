using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulb_Rotation : MonoBehaviour {
    public bool Broken;
    public bool TurnedIn;
    public Transform StartPosition;
    public Transform EndPosition;
    public float Pace = 35f;
    public float speed = 35f;

    private void Update()
    {
        TurnMeIn();
    }

    public void TurnMeIn() {
            if (Input.GetAxis("Horizontal") > 0)
            {
                transform.Rotate(Vector3.up * speed * Time.deltaTime);
                transform.position = Vector3.MoveTowards(transform.position, EndPosition.position, Pace * Time.deltaTime);

                if (transform.position == EndPosition.position)
                {
                    GameObject.Find("Main_Character").GetComponent<CharacterController>().enabled = true;
                    GameObject.Find("Main_Character").GetComponent<CharacterControl>().enabled = true;
                    GameObject.Find("Main Camera").GetComponent<CameraCollision>().enabled = true;
                    GameObject.Find("Main Camera").GetComponent<Bulb_FPs>().enabled = false;
                    GameObject.Find("RH_Bulb_Screw_In").SetActive(false);
                    GameObject.Find("Bulb_Screw_In").GetComponent<Bulb_Rotation>().enabled = false;
                TurnedIn = true;
                if (GameObject.Find("Lever").GetComponent<Socket_Switch>().power == true)
                {
                    if (GameObject.Find("Lever").GetComponent<Socket_Switch>().on == true)
                    {
                         if(Broken == false)
                        {
                            if(TurnedIn == true)
                            {
                                GameObject.Find("Bulb_Screw_In").GetComponent<Light>().enabled = true;
                            } 
                            else
                            {
                                GameObject.Find("Bulb_Screw_In").GetComponent<Light>().enabled = false;
                            }
                        }
                         else
                        {
                            GameObject.Find("Bulb_Screw_In").GetComponent<Light>().enabled = false;
                        }
                    }
                    else
                    {
                        GameObject.Find("Bulb_Screw_In").GetComponent<Light>().enabled = false;
                    }
                }
                else
                {
                    GameObject.Find("Bulb_Screw_In").GetComponent<Light>().enabled = false;
                }

                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.Locked;
                }
            }

            if (Input.GetAxis("Horizontal") < 0)
            {
                transform.Rotate(-Vector3.up * speed * Time.deltaTime);
                transform.position = Vector3.MoveTowards(transform.position, StartPosition.position, Pace * Time.deltaTime);

            if (transform.position == StartPosition.position)
            {
                GameObject.Find("Main_Character").GetComponent<CharacterController>().enabled = true;
                GameObject.Find("Main_Character").GetComponent<CharacterControl>().enabled = true;
                GameObject.Find("Main Camera").GetComponent<CameraCollision>().enabled = true;
                GameObject.Find("Main Camera").GetComponent<Bulb_FPs>().enabled = false;
                GameObject.Find("RH_Bulb_Screw_In").SetActive(false);
                GameObject.Find("Bulb_Screw_In").GetComponent<Bulb_Rotation>().enabled = false;
                TurnedIn = false;

                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }     
    }
}
