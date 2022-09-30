using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 1f; 
    // Start is called before the first frame update
    [SerializeField] float moveSpeed = 0.01f; // Adds the atribute to the game engine to edit easier
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            float steerAmount = Input.GetAxis("Horizontal") * steerSpeed; //Grabs the hoizontal control and multiply to have the player use steer speed while entering the key
            float moveAmount = Input.GetAxis("Vertical") * moveSpeed;  
            transform.Rotate(0, 0, -steerAmount); //Calls the rotation use zed add negative to fix the steering
            transform.Translate(0, moveAmount, 0); //Calls the car to move forward use the Y-Axis
        //f stands for float use with decimals 
    }
}
