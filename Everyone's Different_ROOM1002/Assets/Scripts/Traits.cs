using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Traits Collection", menuName = "Traits")]
public class Traits : ScriptableObject
{
    //public List<string> traits = new List<string>();
    //public string id;
    public List<TraitID> playerTraits;
}
[System.Serializable]
public struct TraitID
{
    public string traitID;
    public PlayerTraits traits;
}
[System.Serializable]
public enum PlayerTraits
{ 
    None,
    Sarcastic,
    Athletic

}

