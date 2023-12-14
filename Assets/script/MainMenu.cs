using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
   public void Play()
    {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//when clicking on play,it takes u to another scene 
    }
    public void HowtoPlay()
    {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);//when clicking on how to play,it takes u to another scene 
    }
    public void Xplane()
    {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);//when clicking on xplain title,it takes u to another scene 
    }

    public void xtoplay()
    {
    SceneManager.LoadScene("How to play");//takes u to how to play
    }
    public void quit()
    {
    Application.Quit();
    Debug.Log("player has quit");//force quits the game lol
    }
    
}
