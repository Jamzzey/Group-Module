using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invincible : MonoBehaviour

{ 



        void OnTriggerEnter(Collider other)
        {
            if (other.name == "Cube")
            {
                Globals.invincible = true;
                Invoke("endPowerup", 7);
                gameObject.SetActive(false);

            }

        }
        void endPowerup()
        {
            Globals.invincible = false;
        }
    
}
