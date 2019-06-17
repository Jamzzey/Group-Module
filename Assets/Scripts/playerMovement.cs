using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
     

    void FixedUpdate()
    {

        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(inputHorizontal,0, inputVertical * -1);
        rb.AddForce(movement * speed * Time.deltaTime );
    }

    private void Update()
    {


    }
 
}
