using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collection : MonoBehaviour
{


    private Rigidbody rigidBody;
    public int scoreMultiplier;
    public int scoreMultiplierAmount = 5;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        if (Globals.score > 20000) { Globals.coinScore = 5000; scoreMultiplier = 100; }  
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            other.gameObject.SetActive(false);
            Globals.score += Globals.coinScore; 

        }

        if (other.gameObject.tag == "ScoreDouble")
        {
            other.gameObject.SetActive(false);
            Globals.scoreMultiplier = Globals.scoreMultiplier * scoreMultiplierAmount;
            Invoke("endScoreMultiplier", 5);

        }



    }
    void endScoreMultiplier()
    {
        Globals.scoreMultiplier /= scoreMultiplierAmount;
    }



}
