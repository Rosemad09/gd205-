using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alien : MonoBehaviour
{
Rigidbody rb;
    public float forceMultiplier = 5f;

    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKey(KeyCode.W)){
            rb.AddForce(transform.forward * forceMultiplier);//the longer u hold the w key,it gets faster
        }
        if (Input.GetKey(KeyCode.S)){
            rb.AddForce(-transform.forward * forceMultiplier);//the longer u hold the s key,it gets faster
        }
        if (Input.GetKey(KeyCode.A)){
            rb.AddForce(-transform.right * forceMultiplier);//the longer u hold the A key,it gets faster
        }
        if (Input.GetKey(KeyCode.D)){
            rb.AddForce(transform.right * forceMultiplier);//the longer u hold the d key,it gets faster
        }
        if (Input.GetKey(KeyCode.LeftShift)){//pressing the shift key keeps your speed at .95 .
            rb.velocity *= 0.95f;
        }
         if (Input.GetKey(KeyCode.E)){
            rb.AddForce(transform.up * forceMultiplier);//the longer u hold the e key,it gets faster
        }
        if (Input.GetKey(KeyCode.Q))
            rb.AddForce(-transform.up * forceMultiplier);//the longer u hold the 1 key,it gets faster
        }
         
     }

