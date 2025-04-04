using Ink.Parsed;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INKDialogueTrigger : MonoBehaviour
{
    [Header("Ink JSON")]
    [SerializeField] public TextAsset inkJSON;



    public void OnClick()
    {
        INKDialogueManager.GetInstance().EnterDialogueMode(inkJSON);
        Debug.Log("Pressed");
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
