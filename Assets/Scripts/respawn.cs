//Made by Merlin Aldrick

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    Vector3 originalPos;

    void Start()
    {
        //Stores the original position of the asteroids 
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        

    }
    void OnTriggerEnter(Collider other)
    {
        //If the asteroids collide with the respawn planes at the end of the tube they will be transported back to their original positions
        if (other.gameObject.tag == "End")
        {
            gameObject.transform.position = originalPos;
        }
       

    }
}
