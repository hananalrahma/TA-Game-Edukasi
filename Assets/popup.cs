using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class popup : MonoBehaviour
{
    

    public GameObject pauseMenuUI;

    public bool GameIsPaused = false;

    public void tampilPopUp()
    {
        if (GameIsPaused == false)
        {
            GameIsPaused = true;
            pauseMenuUI.SetActive(false);
            Pause();
        }
        else if (GameIsPaused == true)
        {
            GameIsPaused = false;
            pauseMenuUI.SetActive(true);
            Resume();
        }
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

    public void LoadHome()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Home");
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene("Level");
    }
}
