using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool isPauseClicked = false;

    [SerializeField] public GameObject pauseMenuUI;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (isPauseClicked )
            {
                Resume();
            }

            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        isPauseClicked = false;
        Debug.Log("Resuming");
    }

    public void Pause()
    {
        
        pauseMenuUI.SetActive(true);
        isPauseClicked = true;
        Debug.Log("Paused");
    }

    public void MainMenu()
    {
        
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
        isPauseClicked = false;
        Debug.Log("Going to Menu");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

}
