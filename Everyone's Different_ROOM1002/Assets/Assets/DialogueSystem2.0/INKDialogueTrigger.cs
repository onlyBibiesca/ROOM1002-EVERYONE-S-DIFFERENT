using Ink.Parsed;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INKDialogueTrigger : MonoBehaviour
{
    [Header("Ink JSON")]
    [SerializeField] public TextAsset inkJSON;
    //[SerializeField] public TextAsset inkJSON_2;

    //[Header("isAthletic")]
    //[SerializeField] public static bool canActivateAthleticDialogue = false;


    public void OnClick()
    {

        INKDialogueManager.GetInstance().EnterDialogueMode(inkJSON);
        Debug.Log(inkJSON);
        //this is to check if the bool is true or smth
        // if (!canActivateAthleticDialogue) return;
        /*f ()
        {
            INKDialogueManager.GetInstance().EnterDialogueMode(inkJSON);
            Debug.Log(inkJSON);
        }

        else
        {
            INKDialogueManager.GetInstance().EnterDialogueMode(inkJSON_2);
            Debug.Log(inkJSON_2);
        }*/
    }

    /*public void setAthleticDialogueState(bool state)
    {
        canActivateAthleticDialogue=state;
    }*/

   /*public void Update()
    {
        if (InputManager.GetInstance().GetInteractPressed())
        {
            INKDialogueManager.GetInstance().EnterDialogueMode(inkJSON);
            Debug.Log("Pressed");
        }
    }*/
}
