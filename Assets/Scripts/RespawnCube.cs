//Made by Merlin Aldrick 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnCube : MonoBehaviour
{



    Vector3 originalPos;
    void Start()
    {
        //Stores the original position of the powerups
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
       
        
    }




    //Transports the powerups back to the top if they hit the respawning planes at the bottom of the tube
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "End")
        {
            gameObject.transform.position = originalPos;
            
        }


    }




}

