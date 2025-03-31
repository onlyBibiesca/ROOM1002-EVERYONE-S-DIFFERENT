using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Traits Collection", menuName = "Traits")]
public class Traits : ScriptableObject
{
    public string traitsID;
    public List<string> traits = new List<string>();
}
