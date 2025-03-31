using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class PlayerManager : MonoBehaviour
{
    public PlayerStats stats;
    public Traits traitsList;

    public void ShowDebug()
    {
        if (traitsList != null)
        {

            string firstItem = traitsList.traits[2];
            Debug.Log(firstItem);

            
        }
        
    }

    public void AddStatEffect()
    {

    }
}
