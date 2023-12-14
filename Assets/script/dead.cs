using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dead : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bad"))//if the player collides with the tag,it reloads the level.
        {
            die();
        }
    }
    void die()
    {
       
        ReloadLevel();


    }
    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);//resets the stage 
    }
}
