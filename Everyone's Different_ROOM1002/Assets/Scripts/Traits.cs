using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Traits
{
    public string id;
    public GeneralStats gStats;
}

[System.Serializable]

public struct GeneralStats
{
    public int Sarcastic;
    public int Pessimistic;
    public int Athletic;
    public int Workaholic;
    public int PassiveAggressive;
}

public struct PlayerHUD
{
    public int health;
    public int hunger;
    public int socialBattery;
    public int energyMeter;
}
