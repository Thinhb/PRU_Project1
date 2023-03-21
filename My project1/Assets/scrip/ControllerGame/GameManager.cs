using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;
    PlayerHealth healthPlayer;
    void Start()
    {
        healthPlayer= FindObjectOfType<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        if (healthPlayer.currentHealth <= 0) 
        {
            gameOver();
            
        }
        Debug.Log(healthPlayer.currentHealth);
    }

    public void gameOver()
    {
        gameOverUI.SetActive(true);
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("Restart");
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("Menu");
        Debug.Log("mainMenu");
    }
    public void quit()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
