using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InsidePlayer : MonoBehaviour
{
    public static bool isPlayerInside  = false;

    [SerializeField] public GameObject InsidePlace;

    public void OnClickEvent()
    {
        InsidePlace.SetActive(true);
        isPlayerInside = true;
        Debug.Log("Player enters " +  InsidePlace);
    }

    public void GoOutside()
    {
        InsidePlace.SetActive(false);
        isPlayerInside = false;
        Debug.Log("Player exits " + InsidePlace);
    }
}
