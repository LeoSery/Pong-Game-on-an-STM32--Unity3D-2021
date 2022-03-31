using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject MainMenuUI;

    private GameManager GameManager;

    private void Awake()
    {
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameManager.isInGame == true)
            {
                if (GameIsPaused)
                {
                    Resume();
                }
                else
                {
                    Pause();
                }
            }
        }
    }

    public void PlayWithAI()
    {
        GameManager.isInGame = true;
        GameIsPaused = false;
        MainMenuUI.SetActive(false);
        pauseMenuUI.SetActive(false);

        GameManager.PrepareGameForAI();
        GameManager.LoadGameUI();
    }

    public void PlayWithPlayers()
    {
        GameManager.isInGame = true;
        GameIsPaused = false;
        MainMenuUI.SetActive(false);
        pauseMenuUI.SetActive(false);

        GameManager.PrepareGameForTwoPlayers();
        GameManager.LoadGameUI();
    }

    public void MainMenu()
    {
        pauseMenuUI.SetActive(false);
        MainMenuUI.SetActive(true);
        Time.timeScale = 1f;
        GameManager.isInGame = false;
    }
   
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    
    public void Reload()
    {
        SceneManager.LoadScene("Main");
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
