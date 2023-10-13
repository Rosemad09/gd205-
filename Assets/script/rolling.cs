using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rolling : MonoBehaviour

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
        
        if (Input.GetKeyDown(KeyCode.A)){
        rb.AddForce(transform.forward *forceMultiplier);
        }

        if (Input.GetKeyDown(KeyCode.D)){
        rb.AddForce(transform.right * forceMultiplier);
        }


    }
}
