using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
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
