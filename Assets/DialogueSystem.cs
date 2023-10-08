using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private CanvasRenderer background;

    private bool dialogueSystemActive = false;

    private Queue<string> dialogueQueue = new Queue<string>();

    public void StartDialogue(DialogueSet dialogueSet)
    {
        foreach(string str in dialogueSet.dialogueStrings)
        {
            dialogueQueue.Enqueue(str);
        }
        dialogueSystemActive = true;
        DisplayString(dialogueQueue.Dequeue());
    }

    private void DisplayString(string str)
    {
        background.gameObject.SetActive(true);
        dialogueText.gameObject.SetActive(true);
        dialogueText.text = str;
    }

    public void Update()
    {
        if(Input.GetMouseButtonDown(0) && dialogueSystemActive)
        {
            string str = dialogueQueue.Dequeue();
            if(dialogueQueue.Count >= 0)
            {
                DisplayString(str);
            }

            if (dialogueQueue.Count == 0)
            {
                dialogueSystemActive = false;
                background.gameObject.SetActive(false);
                dialogueText.gameObject.SetActive(false);
            }
        }
       
    }
}
