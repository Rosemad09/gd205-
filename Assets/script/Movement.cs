using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;

    public Transform orientation;

    float horizontalInput;//how i will move horizontal
    float verticalInput;//how i will move vertical 
  
    Vector3 moveDirection;//how i will be moving 

    Rigidbody rb;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freeze rotation = true;
    }
    private void update()
    {
    MyInput();
    }
    
    private void FixedUpdate(){
   
    MovePlayer();
    }

   private void MyInput()
   {
    horizontalInput = Input.GetAxisRaw("Horizontal");
    verticalInput = Input.GetAxisRaw("vertical");
   }
  
   private void MovePlayer()
   {
   //this code essentially calculates how movement and direction you are going 
   moveDirection = orientation.foward * verticalInput + orientation.right * horizontalInput;

   rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
   
   
   }
   }
