using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dialogue Collection", menuName = "Dialogue/Dialogue Collection")]
public class DialogueCollection : ScriptableObject
{
    public List<Dialogue> dialogues; //list of dialogues
    public string CollectionID; //ID name for the collection for the NPC
}
