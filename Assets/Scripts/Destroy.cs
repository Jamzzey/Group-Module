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
        if (col.gameObject.name == "Cube" && Globals.invincible == false)
        {
            Destroy(col.gameObject);
            Globals.playerAlive = false;
        }
        
    }

 
}
