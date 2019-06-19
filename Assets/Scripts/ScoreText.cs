using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private string playerScore;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
      
    }

    // Update is called once per frame
    void Update()
    {
        playerScore = Globals.score.ToString();
        scoreText.text = "Score: " + playerScore;
        if (Globals.playerAlive == true) { Globals.score += Globals.scoreMultiplier; }
    }
}
