//Made by Merlin Aldrick

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InvincibleText : MonoBehaviour
{
    //Variable for the invincibility icon
    
    public GameObject invincibleIcon;
  
   

    
    void Update()
    {
        //Invincible Icon appears when the player picks up the powerup
        if (Globals.invincible == false) { invincibleIcon.SetActive(false); }
        if (Globals.invincible == true) { invincibleIcon.SetActive(true); } 
      
    }
}

