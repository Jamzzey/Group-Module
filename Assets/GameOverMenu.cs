using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverMenu : MonoBehaviour
{
    public void StartAgain(string scenename)
    {
        Application.LoadLevel(scenename);    
    }

    public void Home(string scenename)
    {
        Application.LoadLevel(scenename);
    }
}
