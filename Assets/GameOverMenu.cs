using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void StartAgain(string scenename)
    {
        SceneManager.LoadScene("infiniteRunnerPrototype");    
    }

    public void Home(string scenename)
    {
        SceneManager.LoadScene("Main Menu");
    }
}
