using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour

{

    float smooth = 5.0f;
    float tiltAngle = 60.0f;


   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;

      Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);
      transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * smooth);
    }
}
