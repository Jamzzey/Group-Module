using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool Paused = false;

    public GameObject PauseM;

    public void Home()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Paused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        PauseM.SetActive(false);
        Paused = false;
        Time.timeScale = 1f;
        Globals.playerAlive = true;
    }

    public void Pause()
    {
        PauseM.SetActive(true);
        Paused = true;
        Time.timeScale = 0f;  
        Globals.playerAlive = false;
    }
}