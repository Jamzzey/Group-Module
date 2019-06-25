//Made by Merlin Aldrick

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InvincibleText : MonoBehaviour
{
    //Variable for the invincibility text
    public TextMeshProUGUI invincibleText;
  
  
    void Start()
    {
        invincibleText = GetComponent<TextMeshProUGUI>();

    }

    
    void Update()
    {
       //Makes sure the font isn't there if the player isn't invincible, and then comes up saying "Invincible!" once the powerup is collected
       if (Globals.invincible == false) invincibleText.text = " ";
       if (Globals.invincible == true) invincibleText.text = "Invincible!";
      
    }
}

