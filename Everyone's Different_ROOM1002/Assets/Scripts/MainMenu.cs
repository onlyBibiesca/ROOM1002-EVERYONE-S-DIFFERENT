using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    [SerializeField] public GameObject buttons;

    //Play Button
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Switching to gameplay");
    }

    //Quit Button
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }    
}
