﻿//Made by Merlin Aldrick

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globals : MonoBehaviour

{
    
    //All of the global variables that are to be used over multiple scripts 
    public static bool invincible = false;
    public static int invincibleLength = 7;
    public static bool scorePowerup = false; 
    public static int score = 0;
    public static bool playerAlive = true;
    //This is the amount that the score will increase by every frame and can be changed using the powerups to increase it by different amounts 
    public static int scoreMultiplier = 2;
    //This is how much the players score increases when picking up a coin
    public static int coinScore = 1000;
    //This is the amount that the score multiplier will be multiplied by when the score powerup is collected 
    public static int scoreMultiplierAmount = 5;
}