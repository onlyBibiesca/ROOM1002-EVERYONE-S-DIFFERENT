/*using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using TMPro;
using UnityEngine;

public class DialogueSystem : MonoBehaviour
{
    public static DialogueSystem Instance { get; private set; }

    // UI references
    public GameObject DialogueParent; // Main container for dialogue UI
    public TextMeshProUGUI DialogTitleText, DialogBodyText; // Text components for title and body
    public DialogueDatabase database;

    public GameObject playerUI; //element for PlayerUI



    private void Awake()
    {
        // Singleton pattern to ensure only one instance of DialogueManager
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    
    //dialoguesystem
    //TO DO:
    //1 Make a function that will return a diALOGUE COLLECTION based on the collectionID from the database (database)
    //2 make another function that will return a specific dialogue based on the given dialogue collection (dialogue ID)
    //3 make another function that will return the list of dialogues from a dialogue
    //4 make a function that will return the list of choices from a dialogue
    public List<string> GetDialogueList(string dialogueID) //3
    {
        // do logic here
        var targetDialogue = GetDialogueFromCollection(dialogueID);
        return targetDialogue.dialogues;
    }

    public Dialogue GetDialogueFromCollection(string dialogueID) //2
    {
        // Return a dialogue from the dialogue collection id
        
    }

    public DialogueCollection GetDialogueCollection(string collectionID) //1
    {
        
    }

    public void StartDialogue(string collectionID, string dialogueID)
    {
        var dialogueCollection = GetDialogueCollection(collectionID); //gets the dialogue collection according to their CollectionID
        var dialogue = GetDialogueFromCollection(dialogueCollection); //gets the dialogues from that collection
        var dialogues = GetDialogueList(dialogue); //plays the dialogue list from GetDialogueFromCollection

        // TODO: Call the UI script to display all dialogues here
    }


}*/