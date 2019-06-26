//Made by Merlin Aldrick

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class scorePowerupIcon : MonoBehaviour
{
    //Variable for the score powerup icon

    public GameObject PowerupIcon;

  



    void Update()
    {
        //brings up the score powerup icon for as long as the score powerup is active 
        if (Globals.scorePowerup == false) { PowerupIcon.SetActive(false); }
        if (Globals.scorePowerup == true) { PowerupIcon.SetActive(true); }

    }
}

