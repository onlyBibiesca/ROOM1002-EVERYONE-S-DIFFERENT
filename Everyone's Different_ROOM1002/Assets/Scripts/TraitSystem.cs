using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TraitCollection", menuName = "Traits")]
public class TraitSystem : ScriptableObject
{
    public string traitID;
    public List<Traits> traits;
}
