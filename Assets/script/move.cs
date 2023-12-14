using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public GameObject hazard;
    public GameObject[] hazards;
    public AudioClip oof;
    AudioSource player; 
    Vector3 startPos;


    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        player= GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.W)){//allows you to move back
        Debug.Log("W key pressed");
        transform.position += Vector3.back;

        }
        if (Input.GetKeyDown(KeyCode.S)){//allows you to move foward
        Debug.Log("s key pressed");
        transform.position += Vector3.forward;

        }
        if (Input.GetKeyDown(KeyCode.A)){//allows you to move left
        Debug.Log("a key pressed");
        transform.position += Vector3.left;
         }
    
    if (Input.GetKeyDown(KeyCode.D)){//allows you to move right
        Debug.Log("d key pressed");
        transform.position += Vector3.right;

        }
    if (Input.GetKeyDown(KeyCode.Q)){//allows you to move down
        Debug.Log("q key pressed");
        transform.position += Vector3.down;

        }
    if (Input.GetKeyDown(KeyCode.E)){//allows you to move up
        Debug.Log("e key pressed");
        transform.position += Vector3.up;

        }
    if (transform.position == hazard.transform.position){
        Debug.Log("you are hazard");
    }
    
    for(int i=0; i < hazards.Length; i++){
if (transform.position == hazards[i].transform.position){
        Debug.Log("you are hazards ): hehe");//if u land on that area,the log
        //Destroy(gameObject);
     transform.position = startPos;
     player.PlayOneShot(oof, .75f);
    }
    } 
    
    }
}
