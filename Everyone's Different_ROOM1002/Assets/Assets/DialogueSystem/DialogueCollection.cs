using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dialogue Collection", menuName = "Dialogue/Dialogue Collection")]
public class DialogueCollection : ScriptableObject
{
    public List<Dialogue> dialogues; //in this list, it does not need to create another node, it continues to make it mroe efficient and not nested
    public string CollectionID;
}
