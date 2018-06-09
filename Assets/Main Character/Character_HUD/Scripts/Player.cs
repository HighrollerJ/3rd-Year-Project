using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Player : MonoBehaviour {
    [SerializeField]
    private Stat health;
    [SerializeField]
    public Stat stamina;
    [SerializeField]
    private Stat energy;
    public float numberOfSeconds;

    private void Awake()
    {
        health.Initialize();
        stamina.Initialize();
        energy.Initialize();
    }
    void Start()
    {
        InvokeRepeating("Decrease", 1.0f, numberOfSeconds);
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            health.CurrentVal -= 10;
        }
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            health.CurrentVal += 10;
        }
        if(Input.GetKey(KeyCode.LeftShift))
        {
            stamina.CurrentVal -= 0.8f;
        }
        stamina.CurrentVal += 0.5f;
        
    }
    void Decrease()
    {
        if(energy.CurrentVal > 0)
        {
            energy.CurrentVal -= 1;
        }
    }
}
