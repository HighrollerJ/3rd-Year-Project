using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour {
    public Texture2D defaultTexture;
    public Texture2D door;
    public Texture2D toggle;
    public Texture2D fix;
    public Texture2D button;
    public Texture2D breaker;

    public CursorMode cursor = CursorMode.Auto;
    public Vector2 spot = Vector2.zero;

	// Use this for initialization
	void Start () {
        Cursor.SetCursor(defaultTexture, spot, cursor);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseEnter()
    {
        if(gameObject.tag == "Fix")
        {
            Cursor.SetCursor(fix, spot, cursor);
        }
        else if(gameObject.tag == "Door")
        {
            Cursor.SetCursor(door, spot, cursor);
        }
        else if (gameObject.tag == "Toggle")
        {
            Cursor.SetCursor(toggle, spot, cursor);
        }
        else if (gameObject.tag == "Button")
        {
            Cursor.SetCursor(button, spot, cursor);
        }
        else if (gameObject.tag == "Breaker")
        {
            Cursor.SetCursor(breaker, spot, cursor);
        }
        else if (gameObject.tag == "LB_Bed_Top")
        {
            Cursor.SetCursor(breaker, spot, cursor);
        }
        else if (gameObject.tag == "PB_Bed_Top")
        {
            Cursor.SetCursor(breaker, spot, cursor);
        }
    }

    private void OnMouseExit()
    {
        Cursor.SetCursor(defaultTexture, spot, cursor);
    }
}
