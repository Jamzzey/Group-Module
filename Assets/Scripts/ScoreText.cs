//Made by Merlin Aldrick

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreText : MonoBehaviour
{
    //Variable for the score text
    public TextMeshProUGUI scoreText;
    //Variable for the text that will display the score 
    private string playerScore;

    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
      
    }

    // Update is called once per frame
    void Update()
    {
        //Changing the player score interger into a string so it can be displayed as text 
        playerScore = Globals.score.ToString();
        //Updating the text along with the score so the score is displayed on the screen
        scoreText.text = "Score: " + playerScore;
        //If the player is still alive, the players score will increase by the score multiplier amount every frame 
        if (Globals.playerAlive == true) { Globals.score += Globals.scoreMultiplier; }
    }
}
