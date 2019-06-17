using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public Text scoreText;
    private string playerScore;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
      
    }

    // Update is called once per frame
    void Update()
    {
        playerScore = Globals.score.ToString();
        scoreText.text = "Score: " + playerScore;
        if (Globals.playerAlive == true) { Globals.score++; }
    }
}
