using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuScreen : MonoBehaviour
{
    [Header("GameObjects")]
    public GameObject Menu;
    public GameObject playerUI;

    [Header("NPC")]
    public GameObject npc;


    public static bool isActive = false;

    private void Start()
    {
        isActive = false;
        Menu.SetActive(false);
    }

    public void MenuFood()
    {
        Menu.SetActive(true);
        playerUI.SetActive(false);
        npc.SetActive(false);
    }

    public void Exit()
    {
        Menu.SetActive(false);
        playerUI.SetActive(true);
        npc.SetActive(true);
    }
}
