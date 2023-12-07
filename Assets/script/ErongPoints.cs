using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErongPoints : MonoBehaviour
{
    int p = 0;
    public AudioSource source;
    public AudioClip PointUp;
  

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Erong"))
        {
            source.PlayOneShot(PointUp);
            Destroy(other.gameObject, .3f);
            scorep.scorecount += 1;
            Debug.Log("p" + p);
            
        }
    }
}
