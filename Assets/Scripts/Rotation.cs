//Made by Merlin Aldrick

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    
    void Start()
    {
      //Randomises the rotation of the asteroids as they spawn
      gameObject.transform.rotation = Random.rotation;  
    }


}
