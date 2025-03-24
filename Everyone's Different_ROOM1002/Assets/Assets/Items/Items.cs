using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;



public class Items : MonoBehaviour
{

    [SerializeField]
    private string itemName;
    [SerializeField]
    private int quantity;
    [SerializeField]
    private Sprite sprite;

    public InventoryManager inventoryManager;

    void Start()
    {
        inventoryManager = GameObject.Find("InventoryManager").GetComponent<InventoryManager>();
    }

    //For receiving items only once, ie "Get item from corner, it dissapears and goes to your bag"
    public void ItemReceiveSing()
    {
        inventoryManager.AddItem(itemName, quantity, sprite);
        Destroy(gameObject);
    }

    //For receiving items multiple times, ie "Buy item from store, limitless supply"
    public void ItemReceiveMult()
    {
        inventoryManager.AddItem(itemName, quantity, sprite);
    }
}
/*[System.Serializable]
public class Item
{
    public string itemName;
    public int itemID;
    public string itemDesc;
    //public Texture2d itemIcon;
    public int itemHunger;
    public int ItemEnergy;
    public int ItemMood;
    public ItemType itemType;

    public enum ItemType
    {
        Food,
        Quest


    }


}
*/