using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
   public void play()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitMenu()
    {
        SceneManager.LoadScene(0);
    } 
  public  void Exit()
    {
        Application.Quit();
    }
    public void PauseGame()
    {
      Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
    public void GoToMeun()
    {
        SceneManager.LoadScene(0);
    }
}
