using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.EventSystems;

public class INKDialogueManager : MonoBehaviour
{
    [Header("Params")]
    [SerializeField] private float typingSpeed = 0.02f;

    [Header("PlayerUI to Hide")]
    [SerializeField] public GameObject NPC_1;
    [SerializeField] public GameObject NPC_2;
    [SerializeField] public GameObject playerUI;
    [SerializeField] public GameObject ExitButton;

    [Header("Dialogue UI")]
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private TextMeshProUGUI displayNameText;
    [SerializeField] public GameObject continueButton;

    [Header("Choices UI")]
    [SerializeField] private GameObject[] choices;
    private TextMeshProUGUI[] choicesText;

    private Story currentStory;

    public bool isDialoguePlaying;

    private Coroutine displayLineCoroutine;

    private static INKDialogueManager instance;

    private const string SPEAKER_TAG = "speaker";

    [SerializeField] private Traits playerTraits;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Found more than one INKDialogueManager in the scene");
        }
        instance = this;
    }

    private void Start()
    {
        isDialoguePlaying = false;
        dialoguePanel.SetActive(false);

        choicesText = new TextMeshProUGUI[choices.Length];
        int index = 0;
        foreach (GameObject choice in choices)
        {
            choicesText[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
            index++;
        }
    }

    private void Update()
    {
        //return if dialogue isnt playing
        if (!isDialoguePlaying)
        {
            return;
        }
    }

    public static INKDialogueManager GetInstance()
    {
        return instance;
    }

    public void EnterDialogueMode(TextAsset inkJSON, bool isAthletic)
    {
        currentStory = new Story(inkJSON.text);

        // Set player trait in the story (assuming the first trait as an example)
        if (playerTraits != null && playerTraits.playerTraits.Count > 0)
        {
            currentStory.variablesState["playerTrait"] = playerTraits.playerTraits[0].traitID;
            Debug.Log("Player trait set to: " + playerTraits.playerTraits[0].traitID);
        }

        //send those bools to ze ink
        currentStory.variablesState["hasAthletic"] = isAthletic;

        //TEST
        //this is not logging when the bool is set to false, for some reason, which means this isn't running and is affecting everything else
        //When testing, if the bool is set to true, it works when clicking the "Answer Phone" button.
        //But, there's no log at all if the bool is set to false. Which means, this entire function is not... Functioning.
        //After some testing in the ink file itself by setting [VAR hasAthletic = isAthletic], it still works with the true.
        Debug.Log("isAthletic bool is currently set to... " + isAthletic + ".");

        isDialoguePlaying = true;
        dialoguePanel.SetActive(true);
        NPC_1.SetActive(false);
        NPC_2.SetActive(false);
        playerUI.SetActive(false);
        ExitButton.SetActive(false);

        ContinueStory();
    }
    private void ExitDialogueMode()
    {
        isDialoguePlaying = false;
        dialoguePanel.SetActive(false);
        NPC_1.SetActive(true);
        NPC_2.SetActive(true);
        playerUI.SetActive(true);
        ExitButton.SetActive(true);
        dialogueText.text = "";
    }

    public void ContinueStory()
    {
        if (currentStory.canContinue)
        {
            if(displayLineCoroutine != null)
            {
                StopCoroutine(displayLineCoroutine);
            }
            displayLineCoroutine = StartCoroutine(DisplayLine(currentStory.Continue()));
             DisplayChoices();

            HandleTags(currentStory.currentTags);
        }

        else
        {
            ExitDialogueMode();
        }
    }

    private IEnumerator DisplayLine(string line)
    {
        //empty the dialogue
        dialogueText.text = "";

        foreach (char letter in line.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    private void HandleTags(List<string> currentTags)
    {
        foreach (string tag in currentTags)
        {
            string[] splitTag = tag.Split(':');
            if (splitTag.Length != 2)
            {
                Debug.LogError("Tag could not be parsed " + tag);
                continue;
            }
            string tagKey = splitTag[0].Trim();
            string tagValue = splitTag[1].Trim();

            switch (tagKey)
            {
                case SPEAKER_TAG:
                    displayNameText.text = tagValue;
                    break;

                case "trait":
                    if (!PlayerHasTrait(tagValue))
                    {
                        Debug.LogWarning("Player does not have the required trait: " + tagValue);
                    }
                    break;

                default:
                    Debug.LogWarning("Unhandled tag: " + tag);
                    break;
            }
        }
    }

    private bool PlayerHasTrait(string trait)
    {
        foreach (TraitID playerTrait in playerTraits.playerTraits)
        {
            if (playerTrait.traitID.Equals(trait, System.StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }
        return false;
    }

    //displays the choices after no dialogues can be continued
    private void DisplayChoices()
    {
        List<Choice> currentChoices = currentStory.currentChoices;

        if(currentChoices.Count > choices.Length)
        {
            Debug.LogError("More choices were given than the UI can support" + currentChoices.Count);
        }

        int index = 0;
        foreach(Choice choice in currentChoices)
        {
            choices[index].gameObject.SetActive(true);
            choicesText[index].text = choice.text;
            index++;
        }

        for (int i = index; i < choices.Length; i++)
        {
            choices[i].gameObject.SetActive(false);
        }
        StartCoroutine(SelectFirstChoice());
    }

    private IEnumerator SelectFirstChoice()
    {
        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(choices[0].gameObject);
    }

    //This gives the player choices
    public void MakeCHoice(int choiceIndex)
    {
        currentStory.ChooseChoiceIndex(choiceIndex);
        ContinueStory();
        
    }
}
