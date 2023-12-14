using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiraPoints : MonoBehaviour
{
    int p = 0;
    public AudioSource source;
    public AudioClip PointUp;
   

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Kira"))//if the object is tagged as Kira, and it interacts with this code,it will destroy the item and give the score counter 1 point.
        {
            source.PlayOneShot(PointUp);
            Destroy(other.gameObject, .3f);
            scorep.scorecount += 1;
            Debug.Log("p" + p);
            
        }
    }
}
