//Made by Merlin Aldrick 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnCoin : MonoBehaviour
{
    
    Vector3 originalPos;
    
    void Start()
    {
        //Stores the original positions of the coins 
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
       
    }

   


    //If the coin hits the planes at the bottom of the tube, then the coin is transported back to its original position 
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "End")
        {
            gameObject.transform.position = originalPos;
            
        }


    }




}
