using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collection : MonoBehaviour
{


    private Rigidbody rigidBody;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            other.gameObject.SetActive(false);
            Globals.score += 1000;

        }

        if (other.gameObject.tag == "ScoreDouble")
        {
            other.gameObject.SetActive(false);
            Globals.score = Globals.score * 2;

        }




    }
}
