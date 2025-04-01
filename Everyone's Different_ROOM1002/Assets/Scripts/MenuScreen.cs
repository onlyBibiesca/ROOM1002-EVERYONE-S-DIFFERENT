using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuScreen : MonoBehaviour
{
    [Header("GameObjects")]
    public GameObject CarterMenu;
    public GameObject playerUI;
    public GameObject npc;


    public static bool isActive = false;

    private void Start()
    {
        isActive = false;
        CarterMenu.SetActive(false);
    }

    public void MenuFood()
    {
       
            CarterMenu.SetActive(true);
            playerUI.SetActive(false);
            npc.SetActive(false);
    }

    public void Exit()
    {
        CarterMenu.SetActive(false);
        playerUI.SetActive(true);
        npc.SetActive(true);
    }
}
