//Made by Merlin Aldrick 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invincible : MonoBehaviour

{ 
    void OnTriggerEnter(Collider other)
        {
        //If the powerup collides with the player, the invincibility boolean will be set to true, and then invoke the end powerup after the set amount
        //The powerup will also disappear 
            if (other.name == "Player")
            {
                Globals.invincible = true;
                Invoke("endPowerup", 7);
            gameObject.SetActive(false);

            }

        }
        //this ends the powerup by setting invincibility to false 
        void endPowerup()
        {
            Globals.invincible = false;
        }
    
}
