using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

[CreateAssetMenu]
public class ItemScriptObject : ScriptableObject
{
    [Header("Item")]
    public string itemName;
    public StatToChange statToChange = new StatToChange();
    public int amountChangeStat;

    [Header("PlayerStats")]
    public PlayerStats playerStats;


    public void UseItem()
    {
        if (statToChange == StatToChange.health)
        {
            //example codes if stats are scripted
            //GameObject.Find("HealthManager").GetComponent<Health>().ChangeHealth(amountChangeStat);
            //healthSlider.value += playerStats.hunger;
            Debug.Log("Health Added");
        }

        if (statToChange == StatToChange.hunger)
        {
            Debug.Log("Hunger Added");
        }

        if (statToChange == StatToChange.energy)
        {
            //GameObject.Find("StaminaManager").GetComponent<Stamina>().ChangeStamina(amountChangeStat);
            Debug.Log("Stamina Added");
        }

        if (statToChange == StatToChange.socialbatt)
        {
            //GameObject.Find("StaminaManager").GetComponent<Stamina>().ChangeStamina(amountChangeStat);
            Debug.Log("Stamina Added");
        }
    }




    //sets the item stats
    public enum StatToChange
    {
        none,
        health,
        hunger,
        energy,
        socialbatt,

    };


}
