using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnCube : MonoBehaviour

  
{

    //public MeshRenderer cube;
// Start is called before the first frame update
Vector3 originalPos;
    void Start()
    {
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);

    }





    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "End")
        {
            gameObject.transform.position = originalPos;
            //gameObject.Renderer.Enabled(true);
        }


    }




}

