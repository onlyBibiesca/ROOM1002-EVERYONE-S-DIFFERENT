using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour
{
    public GameObject InventoryScreen;

    public static bool isInventoryClick = false;

    public void OnInventoryBag()
    {
        InventoryScreen.SetActive(true);
        isInventoryClick = true;
        Debug.Log("Going to Inventory");
    }

    public void ExitInventoryBag()
    {
        InventoryScreen.SetActive(false);
        isInventoryClick = false;
        Debug.Log("Exit Inventory");
    }
}
