using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    [Header("References")]
    public PlayerStats stats;
    public Traits traitsList;

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


}
