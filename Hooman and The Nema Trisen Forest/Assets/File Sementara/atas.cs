using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atas : MonoBehaviour
{
    public GameObject atass;
    public DialogueTrigger events;

    private void OnMouseEnter()
    {
        print(name);
        atass.SetActive(true);
    }

    private void OnMouseExit()
    {
        atass.SetActive(false);
    }

    private void OnMouseDown()
    {
        events.TriggerDialogue();
    }
}
