using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DialogueSet", menuName = "ScriptableObjects/DialogueSet", order = 1)]
public class DialogueSet : ScriptableObject
{
    public List<string> dialogueStrings;
}
