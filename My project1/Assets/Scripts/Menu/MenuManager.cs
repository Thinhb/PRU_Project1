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
}
