//Made by Merlin Aldrick

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Destroy : MonoBehaviour
{

    
    private Rigidbody rigidBody;
   
    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision col)
    {
        //If the player collides with the asteroid and the invincibility powerup isn't active, then the players object will be destroyed
        if (col.gameObject.name == "Player" && Globals.invincible == false)
        {
            Destroy(col.gameObject);
            Globals.playerAlive = false;
        }
        
    }

 
}
