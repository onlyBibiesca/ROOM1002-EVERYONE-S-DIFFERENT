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
    public List<StatToChange> statchange;
    public StatToChange statToChange = new StatToChange();
    public int amountChangeStat;

    [Header("PlayerStats")]
    public PlayerStats playerStats;


    public void UseItem()
    {

        PlayerManager playerManager = FindObjectOfType<PlayerManager>();

        if (statToChange == StatToChange.health)
        {
            //example codes if stats are scripted
            //GameObject.Find("HealthManager").GetComponent<Health>().ChangeHealth(amountChangeStat);
            //healthSlider.value += playerStats.hunger;
            playerManager.ChangeHealth(amountChangeStat);
            Debug.Log("Health Added");
        }

        if (statToChange == StatToChange.hunger)
        {
            playerManager.ChangeHunger(amountChangeStat);
            Debug.Log("Hunger Added");
        }

        if (statToChange == StatToChange.energy)
        {
            //GameObject.Find("StaminaManager").GetComponent<Stamina>().ChangeStamina(amountChangeStat);
            playerManager.ChangeEnergy(amountChangeStat);
            Debug.Log("Stamina Added");
        }

        if (statToChange == StatToChange.socialbatt)
        {
            //GameObject.Find("StaminaManager").GetComponent<Stamina>().ChangeStamina(amountChangeStat);
            playerManager.ChangeSocialBattery(amountChangeStat);
            Debug.Log("Social Battery Added");
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
