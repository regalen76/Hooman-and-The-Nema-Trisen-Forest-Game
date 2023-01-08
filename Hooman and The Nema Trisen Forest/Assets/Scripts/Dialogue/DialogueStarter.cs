using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueStarter : MonoBehaviour
{
    public static DialogueStarter Instance;

    public DialogueTrigger events;

    private void Awake()
    {
        Instance = this;   
    }

    public void Trigger()
    {
        StartCoroutine(waitCoroutine());
    }

    public void Trigger2()
    {
        InvestigationGameManager.instance.state = 2;
        GameObject.Find("FinishInvestigating").SetActive(false);
        DialogueTrigger evented = GameObject.Find("Tree Selection Event").GetComponent<DialogueTrigger>();
        evented.TriggerDialogue();
    }

    IEnumerator waitCoroutine()
    {
        yield return new WaitForSeconds(1);
        events.TriggerDialogue();
    }
}
