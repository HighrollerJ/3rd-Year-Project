using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact_Script : MonoBehaviour {
    public float InteractDistance;

    // Update is called once per frame
    void Update () {
		if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            bool didHit = Physics.Raycast(ray, out hit, InteractDistance);
            if(didHit)
            {
                Door_Script door = hit.collider.GetComponent<Door_Script>();
                if (door)
                {
                    GameObject.Find("Door").GetComponent<Door_Script>().ChangeDoorState();
                }

                Bulb_State bulb = hit.collider.GetComponent<Bulb_State>();
                if (bulb)
                {
                    GameObject.Find("Main Camera").GetComponent<Bulb_FPs>().enabled = true;
                    GameObject.Find("Main_Character").GetComponent<CharacterController>().enabled = false;
                    GameObject.Find("Main_Character").GetComponent<CharacterControl>().enabled = false;
                    GameObject.Find("Main Camera").GetComponent<CameraCollision>().enabled = false;
                }

                DBboard_Script board = hit.collider.GetComponent<DBboard_Script>();
                if (board)
                {
                    GameObject.Find("Chute").GetComponent<Verify_Position>().enabled = false;
                    GameObject.Find("DB_Board").GetComponent<DBboard_Script>().enabled = true;
                    GameObject.Find("Main_Character").GetComponent<CharacterController>().enabled = false;
                    GameObject.Find("Main_Character").GetComponent<CharacterControl>().enabled = false;
                    GameObject.Find("Main Camera").GetComponent<CameraCollision>().enabled = false;
                    GameObject.Find("DB_Board").GetComponent<Collider>().enabled = false;
                    //GameObject.Find("Lever").GetComponent<Breaker_Script>().enabled = true;
                }

                //Chute
                Chute_Button chute = hit.collider.GetComponent<Chute_Button>();
                if (chute)
                {
                    GameObject.Find("ButtonDown").GetComponent<Chute_Button>().enabled = true;
                    GameObject.Find("Chute").GetComponent<Verify_Position>().enabled = true;
                }
                Chute_Button_U chute2 = hit.collider.GetComponent<Chute_Button_U>();
                if (chute2)
                {
                    GameObject.Find("ButtonUp").GetComponent<Chute_Button_U>().enabled = true;
                    GameObject.Find("Chute").GetComponent<Verify_Position>().enabled = true;
                }//End Chute

                //Stock Box Screw In
                Box_Hover box = hit.collider.GetComponent<Box_Hover>();
                if (box)
                {
                    GameObject.Find("Storage_Box").GetComponent<Storage_Box>().enabled = false;
                    GameObject.Find("Main Camera").GetComponent<CameraCollision>().enabled = true;

                    GameObject.Find("E27").GetComponent<UnityEngine.UI.Button>().enabled = true;
                    GameObject.Find("B22").GetComponent<UnityEngine.UI.Button>().enabled = false;
                }//End Box Screw In

                /**Stock Box Screw In
                Box_Hover_Bayonette box2 = hit.collider.GetComponent<Box_Hover_Bayonette>();
                if (box2)
                {

                }End Box Screw In**/
            }
        }
	}
}
