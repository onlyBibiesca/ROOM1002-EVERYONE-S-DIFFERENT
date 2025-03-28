using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

[CreateAssetMenu]
public class ItemScriptObject : ScriptableObject
{
    public string itemName;
    public StatToChange statToChange = new StatToChange();
    public int amountChangeStat;

    public void UseItem()
    {
        if (statToChange == StatToChange.health)
        {
            //example codes if stats are scripted
            //GameObject.Find("HealthManager").GetComponent<Health>().ChangeHealth(amountChangeStat);
            Debug.Log("Health Added");
        }

        if (statToChange == StatToChange.hunger)
        {
            //GameObject.Find("HungerManager").GetComponent<Hunger>().ChangeHunger(amountChangeStat);
            Debug.Log("Hunger Added");
        }

        if (statToChange == StatToChange.stamina)
        {
            //GameObject.Find("StaminaManager").GetComponent<Stamina>().ChangeStamina(amountChangeStat);
            Debug.Log("Stamina Added");
        }
    }





    public enum StatToChange
    {
        none,
        health,
        hunger,
        stamina,
        socialbatt,
        mood

    };


}
