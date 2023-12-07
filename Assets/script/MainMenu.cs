using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
   public void Play()
    {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void HowtoPlay()
    {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void Xplane()
    {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

    public void xtoplay()
    {
    SceneManager.LoadScene("How to play");
    }
    public void quit()
    {
    Application.Quit();
    Debug.Log("player has quit");
    }
    
}
