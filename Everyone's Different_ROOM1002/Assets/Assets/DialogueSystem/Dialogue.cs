using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Dialogue
{
    public string id; // this is a name placeholder on what the dialogue asset is for
    public List<string> dialogues;
    public List<ChoiceOption> choices; //this creates a choices for the player and has a target id to come with the trait system
}
[System.Serializable]
public struct ChoiceOption
{
    public string displayText; //no shit display
    public string targetId; //playing the next dialogue after a choice
    public Stats choiceStats; //reference to the trait system
    public string itemId; //ID for items

}
[System.Serializable]
public struct Stats //a psuedo but will reference the trait system
{
    public int Happiness;
    public int Sadness;
    public int Grief;
}
