using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    public string Name;
    public Dialogue dialogue;

    public void OnClick()
    {
        Debug.Log("Speaking to " + Name);
        SpeakTo();
    }

    public void SpeakTo()
    {
        DialogueManager.Instance.StartDialogue(Name, dialogue.RootNode);
    }
}
