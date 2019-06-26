//Made by Merlin Aldrick

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


    private void Update()
    {
        //Makes the coin value increase after the players score reaches a certain amount, and how much the score is multiplied by with the powerups
        if (Globals.score > 20000) { Globals.coinScore = 5000; Globals.scoreMultiplierAmount = 20; }  
    }

    void OnTriggerEnter(Collider other)
    {
        //If the player collides with the coin then the coin object will disappear, and the score will be increased by the coins value 
        if (other.gameObject.tag == "Coin")
        {
           
            other.gameObject.SetActive(false);
            Globals.score += Globals.coinScore; 

        }
        //If the player picks up a score powerup, the amount the score increases every frame will be multiplied by the value of the scoreMultiplierAmount
        //and the powerup will disappear, this will also invoke the end of the powerup after the set amount 
        if (other.gameObject.tag == "ScoreDouble")
        {
            Globals.scorePowerup = true; 
            Globals.scoreMultiplier = Globals.scoreMultiplier * Globals.scoreMultiplierAmount;
            Invoke("endScoreMultiplier", 5);
            other.gameObject.SetActive(false);

        }



    }
    void endScoreMultiplier()
    {
        //Divides the score mulitplier by the amount it was multiplied by in powerup to return it to its original amount
        Globals.scoreMultiplier /= Globals.scoreMultiplierAmount;
        Globals.scorePowerup = false;
    }



}
