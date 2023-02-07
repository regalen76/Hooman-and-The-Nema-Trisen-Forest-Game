using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueStart2 : MonoBehaviour
{
    public DialogueTrigger events;

    void Start()
    {
        StartCoroutine(waitCoroutine());
    }

    IEnumerator waitCoroutine()
    {
        yield return new WaitForSeconds(1);
        events.TriggerDialogue3();
    }
}
