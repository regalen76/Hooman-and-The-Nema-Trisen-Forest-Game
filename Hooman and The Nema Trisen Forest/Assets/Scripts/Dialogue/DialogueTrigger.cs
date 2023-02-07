using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    public void TriggerDialogue2()
    {
        FindObjectOfType<DialogueManager2>().StartDialogue(dialogue);
    }
    
    public void TriggerDialogue3()
    {
        FindObjectOfType<DialogueManager3>().StartDialogue(dialogue);
    }

    public void TriggerDialogue4()
    {
        FindObjectOfType<DialogueManager4>().StartDialogue(dialogue);
    }
}
