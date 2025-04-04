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

    public string selectedTrait;

    void Start()
    {
        isSlider = true;
        healthSlider.value = stats.health;
        hungerSlider.value = stats.hunger;
        energySlider.value = stats.energy;
        socialbatSlider.value = stats.socialBattery;

        selectedTrait = PlayerPrefs.GetString("SelectedTrait", "None");
        ApplyTrait(selectedTrait);
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
    void ApplyTrait(string trait)
    {
        Debug.Log("Applying trait: " + trait);

        switch (trait.ToLower())
        {
            case "sarcastic":
                // Example logic for sarcastic trait
                Debug.Log("This player responds to everything with sass.");
                // You could trigger specific sarcastic dialogue patterns later
                break;

            case "athletic":
                // Example logic for athletic trait
                Debug.Log("This player runs faster or tires slower.");
                // Could tie into movement speed, stamina drain, etc.
                break;

            default:
                Debug.Log("No trait or unknown trait applied.");
                break;
        }
    }


}
