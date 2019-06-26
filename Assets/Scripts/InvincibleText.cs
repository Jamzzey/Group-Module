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
        //Makes sure the font isn't there if the player isn't invincible, and then comes up saying "Invincible!" once the powerup is collected
        if (Globals.invincible == false) { invincibleIcon.SetActive(false); }
        if (Globals.invincible == true) { invincibleIcon.SetActive(true); } 
      
    }
}

