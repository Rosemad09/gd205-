using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public GameObject hazard;
    public GameObject[] hazards; 


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.W)){
        Debug.Log("W key pressed");
        transform.position += Vector3.forward;

        }
        if (Input.GetKeyDown(KeyCode.S)){
        Debug.Log("s key pressed");
        transform.position += Vector3.back;

        }
        if (Input.GetKeyDown(KeyCode.A)){
        Debug.Log("a key pressed");
        transform.position += Vector3.left;
         }
    
    if (Input.GetKeyDown(KeyCode.D)){
        Debug.Log("d key pressed");
        transform.position += Vector3.right;

        }
    if (Input.GetKeyDown(KeyCode.Q)){
        Debug.Log("q key pressed");
        transform.position += Vector3.down;

        }
    if (Input.GetKeyDown(KeyCode.E)){
        Debug.Log("e key pressed");
        transform.position += Vector3.up;

        }
    if (transform.position == hazard.transform.position){
        Debug.Log("you are hazard");
    }
    
    for(int i=0; i < hazards.Length; i++){
if (transform.position == hazards[i].transform.position){
        Debug.Log("you are hazards ): hehe");
        Destroy(gameObject);
    }
    } 
    
    }
}
