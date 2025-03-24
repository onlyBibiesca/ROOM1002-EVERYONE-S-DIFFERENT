using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dialogue Database", menuName = "Dialogue/Dialogue Database")]
public class DialogueDatabase: ScriptableObject
{
    public List<DialogueCollection> Database;
}