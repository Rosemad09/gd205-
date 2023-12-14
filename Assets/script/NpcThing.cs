using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcThing : MonoBehaviour
{
  
    bool player_detection = false;

  
    void Update()
    {
        if(player_detection && Input.GetKeyDown(KeyCode.R))
    {
      print("ello");
    }
        
     }

   

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "playerobj")
        {
            player_detection = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        player_detection = false;
    }
}
