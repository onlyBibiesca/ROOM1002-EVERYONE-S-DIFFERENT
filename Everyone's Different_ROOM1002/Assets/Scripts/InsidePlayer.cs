using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InsidePlayer : MonoBehaviour
{
    public static bool isPlayerInside  = false;

    [SerializeField] public GameObject InsidePlace;
    [SerializeField] public GameObject outsideNPC;
    [SerializeField] public GameObject insideNPC;
    [SerializeField] public GameObject locationArrows;

    public void OnClickEvent()
    {
        InsidePlace.SetActive(true);
        insideNPC.SetActive(true);
        outsideNPC.SetActive(false);
        locationArrows.SetActive(false);
        isPlayerInside = true;
        Debug.Log("Player enters " +  InsidePlace);
    }

    public void GoOutside()
    {
        InsidePlace.SetActive(false);
        insideNPC.SetActive(false);
        outsideNPC.SetActive(true);
        locationArrows.SetActive(true);
        isPlayerInside = false;
        Debug.Log("Player exits " + InsidePlace);
    }
}
