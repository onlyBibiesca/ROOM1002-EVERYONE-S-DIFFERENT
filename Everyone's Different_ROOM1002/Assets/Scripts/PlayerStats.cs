using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "Stats")]
public class PlayerStats : ScriptableObject
{
    public string playerID;

    public int health;
    public int hunger;
    public int energy;
    public int socialBattery;

}
