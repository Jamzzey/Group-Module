//Made by Aziz Ali

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        //When the play button is pressed the game will change to the game scene 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Exit()
    {
        //The game will stop when the exit button is pressed, and display text in the log so we know it works when the game isn't built
        Debug.Log("Exit!!!!!");
        Application.Quit();

    }
}
