using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameState GameState;

    public DialogueTrigger event1;
    public DialogueTrigger event2;

    private int whatEvent;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        ChangeState(GameState.GenerateGrid);
    }

    public void ChangeState(GameState newState)
    {
        GameState = newState;
        switch (newState)
        {
            case GameState.GenerateGrid:
                GridManager.Instance.GenerateGrid();
                break;
            case GameState.SpawnEventDialogue:
                if (UnityEngine.Random.Range(0, 2) == 0)
                {
                    whatEvent = 1;
                    event1.TriggerDialogue();
                }
                else
                {
                    whatEvent = 2;
                    event2.TriggerDialogue();
                }
                break;
            case GameState.SpawnEventObject:
                if (whatEvent == 1)
                {
                    EventManager.Instance.SpawnWolf();
                }
                else
                {
                    EventManager.Instance.SpawnChickin();
                }
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }
    }
}

public enum GameState
{
    GenerateGrid = 0,
    SpawnEventDialogue = 1,
    SpawnEventObject = 2
}
