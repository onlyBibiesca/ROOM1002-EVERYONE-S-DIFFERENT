using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{

    public static bool isOptionsClicked = false;

    public VolumeManager volumeManager;

    public GameObject optionMenuUI;
    

    public void OnClickEvent()
    {
        optionMenuUI.SetActive(true);
        isOptionsClicked = true;
        Debug.Log("Going to Options Menu");
    }

    public void Back()
    {
        optionMenuUI.SetActive(false);
        isOptionsClicked = false;
    }

    public void VolumeManager()
    {
        volumeManager = GetComponent<VolumeManager>();
    }
}
