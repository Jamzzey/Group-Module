using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deletepowerup : MonoBehaviour
{
    void OnTriggerEnter()
    {
        if (gameObject.tag == "Cube" )
        {
            Destroy(gameObject);
        }
       
    }

}
