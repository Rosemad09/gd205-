using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("movement")]
    public float moveSpeed;
    public float groundDrag;
   
    public float jumpforce;
    public float jumpCoolDown;
    public float airM;
    bool readytojump;

    [Header("keybinds")]
    public KeyCode jumpkey = KeyCode.Space;


    [Header("Ground Check")]
    public float pHeight;
    public LayerMask whatisground;
    bool grounded;


    public Transform orientation;

    float horizontalInput;
    float verticleInput;

    Vector3 moveD;
    Rigidbody rb;

    // Start is called before the first frame update
   private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        readytojump = true;

    }

    // Update is called once per frame

    private void Update()
    {
        grounded = Physics.Raycast(transform.position, Vector3.down, pHeight * 0.5f + 0.2f, whatisground);

        myinput();
        speedcontrol();

        if (grounded)
            rb.drag = groundDrag;
        else
            rb.drag = 0;


    }
    private void speedcontrol()
    {
        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
        if(flatVel.magnitude > moveSpeed)
        {
            Vector3 limitedVel = flatVel.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
        }
    }
    private void FixedUpdate()
    {
        mPlayer();
    }

    private void myinput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticleInput = Input.GetAxisRaw("Vertical");

        if(Input.GetKey(jumpkey) && readytojump && grounded)
        {
            readytojump = false;

            jump();

            Invoke(nameof(resetjump), jumpCoolDown);

        }
    }
    private void jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        rb.AddForce(transform.up * jumpforce, ForceMode.Impulse);
    }

        private void resetjump()
        {
            readytojump = true;
        }
    
      
    private void mPlayer()
    {
        moveD = orientation.forward * verticleInput + orientation.right * horizontalInput;
        if (grounded)
            rb.AddForce(moveD.normalized * moveSpeed * 10f, ForceMode.Force);

        else if (!grounded)
            rb.AddForce(moveD.normalized * moveSpeed * airM *10f, ForceMode.Force);


    }


}
    
