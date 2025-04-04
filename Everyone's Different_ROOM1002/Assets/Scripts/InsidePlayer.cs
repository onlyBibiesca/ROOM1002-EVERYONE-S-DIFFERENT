using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InsidePlayer : MonoBehaviour
{
    public static bool isPlayerInside  = false;

    [Header("PlayerUI")]
    public GameObject locationArrows;

    [Header("Inside Objects")]
    public GameObject insideObjects;

    [Header("Outside Objects")]
    public GameObject outsideObjects;

    public void EnterLocation()
    { 
            insideObjects.SetActive(true);
            outsideObjects.SetActive(false);
            locationArrows.SetActive(false);
            Debug.Log("Going inside" + insideObjects);
    }

    public void ExitLocation()
    {
            insideObjects.SetActive(false);
            outsideObjects.SetActive(true);
            locationArrows.SetActive(true);
            Debug.Log("Going outside" + insideObjects);
    }
}
