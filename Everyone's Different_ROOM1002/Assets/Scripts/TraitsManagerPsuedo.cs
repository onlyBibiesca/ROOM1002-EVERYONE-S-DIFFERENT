using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraitsManagerPsuedo : ScriptableObject
{
    public List<Traits> traits;

    public void ShowTrait()
    {
        if(traits != null && traits.Count > 0)
        {
            Debug.Log(traits[1]);
        }
    }
}
