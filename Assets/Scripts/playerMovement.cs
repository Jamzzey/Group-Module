//Made by Merlin Aldrick
// https://learn.unity.com/tutorial/movement-basics?projectId=5c514956edbc2a002069467c#5c7f8528edbc2a002053b70f 
//This tutorial was used to help with the movement, I just adapted it to work in 3D


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    //the amount of force being applied to the object 
    public float speed;
    private Rigidbody rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
     
    //Fixed update makes movement smoother as it is independent of the frame rate 
    void FixedUpdate()
    {
        //Takes the input from the player left and right 
        float inputLeftRight = Input.GetAxis("Horizontal");
        //Takes input from the player up and down 
        float inputUpDown = Input.GetAxis("Vertical");

        //Uses the inputs of the player to create a movement which is accelerated by multiplying it by the speed
        Vector3 movement = new Vector3(inputLeftRight,0, inputUpDown * -1);

        //This takes the movement of the player and multiplies it by the speed and delta time to make smooth movement
        rigidBody.AddForce(movement * speed * Time.deltaTime );
    }

 
}
