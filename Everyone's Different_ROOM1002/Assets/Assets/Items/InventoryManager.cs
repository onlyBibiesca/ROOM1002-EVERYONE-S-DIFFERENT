using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public GameObject InventoryScreen;

    public static bool isInventoryClick = false;

    public ItemDatabase[] itemData;

    public void OnInventoryBag()
    {
        Time.timeScale = 0;
        InventoryScreen.SetActive(true);
        isInventoryClick = true;
        Debug.Log("Going to Inventory");
    }

    public void ExitInventoryBag()
    {
        Time.timeScale = 1;
        InventoryScreen.SetActive(false);
        isInventoryClick = false;
        Debug.Log("Exit Inventory");
    }

    public void AddItem(string itemName, int quantity, Sprite itemSprite, string itemDescription)
    {
        for (int i = 0; i < itemData.Length; i++)
        {
            if (itemData[i].isFull == false)
            {
                itemData[i].AddItem(itemName, quantity, itemSprite, itemDescription);
                Debug.Log("Item Received" + itemName + " " + quantity + " " + itemSprite);
                return;
            }
        }
  
    }

    public void DeselectAllSlots()
    {
        for (int i = 0; i < itemData.Length; i++)
        {
            itemData[i].selectedShader.SetActive(false);
            itemData[i].thisItemSelected = false;
        }
    }
}
