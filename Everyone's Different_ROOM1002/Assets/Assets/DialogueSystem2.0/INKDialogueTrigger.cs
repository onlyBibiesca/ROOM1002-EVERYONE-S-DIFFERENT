using Ink.Parsed;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INKDialogueTrigger : MonoBehaviour
{
    [Header("Ink JSON")]
    [SerializeField] public TextAsset inkJSON;

    [Header("isAthletic")]
    [SerializeField] public bool canActivateAthleticDialogue = false;


    public void OnClick()
    {
        //this is to check if the bool is true or smth
        if (!canActivateAthleticDialogue) return;

        INKDialogueManager.GetInstance().EnterDialogueMode(inkJSON, canActivateAthleticDialogue);
        Debug.Log("Pressed");
    }

    public void setAthleticDialogueState(bool state)
    {
        canActivateAthleticDialogue=state;
    }

   /*public void Update()
    {
        if (InputManager.GetInstance().GetInteractPressed())
        {
            INKDialogueManager.GetInstance().EnterDialogueMode(inkJSON);
            Debug.Log("Pressed");
        }
    }*/
}
