using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvestigationGameManager : MonoBehaviour
{
    public static InvestigationGameManager instance;
    public InvestigationState InvestigationState;

    public int state;
    public GameObject botNav;
    public GameObject FinishInvestigation;
    public GameObject itemButton;
    public GameObject noteButton;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        ChangeState(InvestigationState.LoadFirstDialogue);
    }

    public void ChangeState(InvestigationState newState)
    {
        InvestigationState = newState;
        switch (newState)
        {
            case InvestigationState.LoadFirstDialogue:
                state = 1;
                DialogueStarter evented = GameObject.Find("Event Starter").GetComponent<DialogueStarter>();
                evented.Trigger();
                break;
            case InvestigationState.FirstSelection:
                botNav.SetActive(true);
                break;
            case InvestigationState.SecondSelection:
                state = 3;
                FinishInvestigation.SetActive(false);
                itemButton.SetActive(true);
                noteButton.SetActive(true);
                break;
            case InvestigationState.FinishedSelection:
                state = 4;
                botNav.SetActive(false);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }
    }
}

public enum InvestigationState
{
    LoadFirstDialogue = 0,
    FirstSelection = 1,
    SecondSelection = 2,
    FinishedSelection = 3
}