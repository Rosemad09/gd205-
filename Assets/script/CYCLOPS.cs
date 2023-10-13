using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CYCLOPS : MonoBehaviour

{
public float boomRad = 60f;
public float boomForce = 750f;    
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();

        if(Physics.Raycast(laser, out hit)){
            Debug.Log("Hit "+ hit.transform.name);
            if (Input.GetMouseButton(0) && hit.rigidbody){
                hit.rigidbody.AddExplosionForce(boomForce, hit.point, boomRad); 


            }

        }
    }
}
