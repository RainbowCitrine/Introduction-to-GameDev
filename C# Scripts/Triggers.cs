using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    //Add ur rigid bodys and collisions do not forget to set gravity to zero for certain games
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Oof"); 
    }
    // Do not forget to check off trigger inside of collision within the engine
    void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("Hello?");
    }
}
