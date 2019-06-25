//Made by Merlin Aldrick 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deletepowerup : MonoBehaviour
{
    //If the powerup collides with the player, it will be destroyed 
    void OnTriggerEnter()
    {
        if (gameObject.tag == "Cube" )
        {
            Destroy(gameObject);
        }
       
    }

}
