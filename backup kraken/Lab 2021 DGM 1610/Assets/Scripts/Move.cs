using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float gravForce, jumpForce, speed, xBound, dJump;
    public bool jumpAvailable;
    public bool doubleJump;
    private Rigidbody playerRB;
    public static Vector3 playerPositoin;

    void Start()
    { 
        playerRB = GetComponent<Rigidbody>();
        Physics.gravity *= gravForce;
        jumpAvailable = true;
        doubleJump = false;
    }
    
    void Update()
    {
        if (StatusManager.gameActive)
        {
            playerPositoin = transform.position;
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * Time.deltaTime* speed);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * Time.deltaTime* speed);
            }
            //move left and right
        
            if (transform.position.x < -xBound)
            {
                transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);
            }
            if (transform.position.x > xBound)
            {
                transform.position = new Vector3(xBound, transform.position.y, transform.position.z);
            }
            //sets limits
        
            if (Input.GetKeyDown(KeyCode.Space) && jumpAvailable)
            {
                playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                jumpAvailable = false;
                doubleJump = true;
            }
            // sets jung acording to bool
            if (Input.GetKeyDown(KeyCode.W) && !jumpAvailable && doubleJump)
            {
                playerRB.velocity = transform.up * Time.deltaTime* dJump;
                doubleJump = false;
            }
            //double jump that detects collision and variables then lets you jump 2 times. you do have to use different buttons however.
        }
        
        

    }
    private void OnCollisionEnter(Collision other)
    {
        jumpAvailable = true;
        doubleJump = false;
    }
    //colliding resets bool;
}