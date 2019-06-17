using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InvincibleText : MonoBehaviour
{
    public Text invincibleText;
  
    // Start is called before the first frame update
    void Start()
    {
        invincibleText = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {

       if (Globals.invincible == false) invincibleText.text = " ";
        if (Globals.invincible == true) invincibleText.text = "Invincible!";
      
    }
}

