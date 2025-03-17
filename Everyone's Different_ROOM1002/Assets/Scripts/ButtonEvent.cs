using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent : MonoBehaviour
{
    private DialogueManager manager;
    public GameObject CHOICE_1;

    public void ButtonEntry()
    {
        if (manager.sentences.Count == 0)
        {
            CHOICE_1.SetActive(true);
        }
        else
        {
            CHOICE_1.SetActive(false);
        }
    }




}
