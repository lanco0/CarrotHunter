using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public FixedJoystick joystick;
    public float moveSpeed;

    float hInput, vInput;

    
    void Start()
    {

    }

   
    void Update()
    {
        
        hInput = joystick.Horizontal * moveSpeed;
        vInput = joystick.Vertical * moveSpeed;
    }

    private void FixedUpdate()
    {
        
        transform.Translate(hInput, vInput, 0);
    }
}
