using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
    
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameState GameState;

    private int whatEvent;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        DontDestroyOnLoad(gameObject);
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
                    DialogueTrigger event1 = GameObject.Find("First event").GetComponent<DialogueTrigger>();
                    event1.TriggerDialogue();
                }
                else
                {
                    whatEvent = 2;
                    DialogueTrigger event2 = GameObject.Find("Second event").GetComponent<DialogueTrigger>();
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
            case GameState.InvestigationMode:
                SceneManager.LoadScene(2);
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
    SpawnEventObject = 2,
    InvestigationMode = 3
}
