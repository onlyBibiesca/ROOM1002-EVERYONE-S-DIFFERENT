using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeLocations : MonoBehaviour
{
    //change locations

    //old scripts
    //next location
    /*public void NextLocation()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PreviousLocation()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }*/

    //new scripts
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void District()
    {
        SceneManager.LoadScene(1);
    }

    public void McArthur()
    {
        SceneManager.LoadScene(2);
    }

    public void ShittyPU()
    {
        SceneManager.LoadScene(3);
    }
}
