using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager Instance { get; private set; }

    // UI references
    public GameObject DialogueParent; // Main container for dialogue UI
    public TextMeshProUGUI DialogTitleText, DialogBodyText; // Text components for title and body
    public GameObject responseButtonPrefab; // Prefab for generating response buttons
    public Transform responseButtonContainer; // Container to hold response buttons
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

        // Initially hide the dialogue UI
        HideDialogue();
    }

    // Starts the dialogue with given title and dialogue node
    public void StartDialogue(string title, string CollectionID)
    {
        // Display the dialogue UI
        ShowDialogue();

        // Set dialogue title and body text
        /*DialogTitleText.text = title;
        DialogBodyText.text = node.dialogueText;

        // Remove any existing response buttons
        foreach (Transform child in responseButtonContainer)
        {
            Destroy(child.gameObject);
        }

        // Create and setup response buttons based on current dialogue node
        foreach (DialogueResponse response in node.responses)
        {
            GameObject buttonObj = Instantiate(responseButtonPrefab, responseButtonContainer);
            buttonObj.GetComponentInChildren<TextMeshProUGUI>().text = response.responseText;

            // Setup button to trigger SelectResponse when clicked
            buttonObj.GetComponent<Button>().onClick.AddListener(() => SelectResponse(response, title));
        }*/
    }

    // Handles response selection and triggers next dialogue node
    //will reference ID of ChoiceOption
    public void SelectResponse(string response, string title)
    {
        // Check if there's a follow-up responeID and get the dialogue from the collection and start it again
        /*if (!response.nextNode.IsLastNode())
        {
            StartDialogue(title, response.nextNode); // Start next dialogue
        }

        else
        {
            // If no follow-up node, end the dialogue
            HideDialogue();
        }*/
    }

    // Hide the dialogue UI
    public void HideDialogue()
    {
        DialogueParent.SetActive(false);
        playerUI.SetActive(true);
    }

    // Show the dialogue UI
    private void ShowDialogue()
    {
        DialogueParent.SetActive(true);
        playerUI.SetActive(false);
    }

    // Check if dialogue is currently active
    public bool IsDialogueActive()
    {
        return DialogueParent.activeSelf;
    }
    //TO DO:
    //-Make a function that will return a diALOGUE COLLECTION based on the collectionID from the database (database,
    //-make another function that will return a specific dialogue based on the given dialogue collection (dialogue ID)
}
