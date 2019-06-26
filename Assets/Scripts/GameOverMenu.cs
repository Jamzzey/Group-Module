using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void StartAgain(string scenename)
    {
        Globals.score = 0;
        Globals.coinScore = 1000;
        Globals.scoreMultiplierAmount = 5;
        Globals.playerAlive = true;
        SceneManager.LoadScene("Game Screen");    
    }

    public void Home(string scenename)
    {
        Globals.score = 0;
        Globals.coinScore = 1000;
        Globals.scoreMultiplierAmount = 5;
        Globals.playerAlive = true;
        SceneManager.LoadScene("Main Menu");
    }
}
