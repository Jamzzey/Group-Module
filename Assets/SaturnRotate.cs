using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaturnRotate : MonoBehaviour
{
    private double planetRotation = 102;
    private string YAxis;
    private float YAxisR;
    // Start is called before the first frame update
    void Start()
    {
        
    }
  
    // Update is called once per frame
    void Update()
    {
        YAxis = planetRotation.ToString();  
        planetRotation += 0.000001 * 1;
        YAxisR = float.Parse(YAxis); 

        gameObject.transform.Rotate(17, YAxisR ,256); 


    }


}

