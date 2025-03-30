using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Traits
{
    public string id;
    public GeneralStats gStats;
    public PlayerHUD playerstats;
    public RelationshipLevel RLevel;
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

[System.Serializable]
public struct PlayerHUD
{
    public int health;
    public int hunger;
    public int socialBattery;
    public int energyMeter;
}

[System.Serializable]
public struct RelationshipLevel
{
    public int Angeline;
    public int David;
}
