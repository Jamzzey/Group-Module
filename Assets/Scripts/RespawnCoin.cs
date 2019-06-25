using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnCoin : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 originalPos;
    public static MeshRenderer coinRenderer;
    void Start()
    {
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        coinRenderer = GetComponent<MeshRenderer>();
    }

   



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "End")
        {
            gameObject.transform.position = originalPos;
            coinRenderer.enabled = true; 
        }


    }




}
