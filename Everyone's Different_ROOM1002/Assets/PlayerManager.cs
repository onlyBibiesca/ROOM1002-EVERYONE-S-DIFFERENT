using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static UnityEditor.Progress;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    [Header("References")]
    public PlayerStats stats;
    //public Traits traitsList;
    public GameObject housePlayer;

    [Header("GameObjects")]
    public Slider healthSlider;
    public Slider energySlider;
    public Slider hungerSlider;
    public Slider socialbatSlider;

    public static bool isSlider = false;

    void Start()
    {
        isSlider = true;
        healthSlider.value = stats.health;
        hungerSlider.value = stats.hunger;
        energySlider.value = stats.energy;
        socialbatSlider.value = stats.socialBattery;
    }
    private void Update()
    {
        //GameObject.GetComponent<ItemScriptObject>().MyFunction();
    }

    public void ChangeHealth(int amount)
    {
        stats.health = Mathf.Clamp(stats.health + amount, 0, (int)healthSlider.maxValue);
        healthSlider.value = (float)stats.health;
    }

    public void ChangeHunger(int amount)
    {
        stats.hunger = Mathf.Clamp(stats.hunger + amount, 0, (int)hungerSlider.maxValue);
        hungerSlider.value = (float)stats.hunger;
    }

    public void ChangeEnergy(int amount)
    {
        stats.energy = Mathf.Clamp(stats.energy + amount, 0, (int)energySlider.maxValue);
        energySlider.value = (float)stats.energy;
    }

    public void ChangeSocialBattery(int amount)
    {
        stats.socialBattery = Mathf.Clamp(stats.socialBattery + amount, 0, (int)socialbatSlider.maxValue);
        socialbatSlider.value = (float)stats.socialBattery;
    }



}
