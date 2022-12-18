using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batang : MonoBehaviour
{
    public GameObject batangs;
    public DialogueTrigger events;

    private void OnMouseEnter()
    {
        batangs.SetActive(true);
    }

    private void OnMouseExit()
    {
        batangs.SetActive(false);
    }

    private void OnMouseDown()
    {
        events.TriggerDialogue();
    }
}
