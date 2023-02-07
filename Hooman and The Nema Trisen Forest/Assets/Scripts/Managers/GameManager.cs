using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
    
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameState GameState;
    
    public HealthBar healthBar;
    public GameObject gameover;
    public GameObject truegameover;

    public bool tutor = false;
    public bool first = false;
    public int maxHealth = 100;
    public int currentHealth;

    void Awake()
    {
        if(instance != null){
            Destroy(gameObject);
        }else{
            instance = this;
        }
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        ChangeState(GameState.FirstCutscene);
        currentHealth = 30;
        healthBar.SetMaxHealth(100,currentHealth);
    }

    public void ChangeState(GameState newState)
    {
        GameState = newState;
        switch (newState)
        {
            case GameState.FirstCutscene:
                CutscenesScript cutscene = GameObject.Find("Cutscenes").GetComponent<CutscenesScript>();
                cutscene.cutscene1();
                break;
            case GameState.GenerateGrid:
                GridManager.Instance.GenerateGrid();
                break;
            case GameState.SpawnEventDialogue:
                DialogueTrigger event1 = GameObject.Find("First event").GetComponent<DialogueTrigger>();
                event1.TriggerDialogue();
                break;
            case GameState.SpawnEventObject:
                EventManager.Instance.SpawnTree();
                break;
            case GameState.InvestigationMode:
                SceneManager.LoadScene(1);
                break; 
            case GameState.InvestigationMode2:
                SceneManager.LoadScene(2);
                break; 
            case GameState.InvestigationMode3:
                SceneManager.LoadScene(3);
                break; 
            case GameState.InvestigationMode4:
                SceneManager.LoadScene(4);
                break;             
            case GameState.Chapter1:
                tutor = true;
                StartCoroutine(waitCoroutine());
                break; 
            case GameState.GameOver:
                postScript posted = GameObject.Find("postCanvas").GetComponent<postScript>();
                posted.win();
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }
    }

    IEnumerator waitCoroutine()
    {
        yield return new WaitForSeconds(1);
        GridManager.Instance.GenerateGrid();
        HealthBar bar = GameObject.Find("Health bar").GetComponent<HealthBar>();
        bar.SetMaxHealth(100,currentHealth);
        if(currentHealth < 15){
            postScript posted = GameObject.Find("postCanvas").GetComponent<postScript>();
            posted.lose();
        }else if (currentHealth > 44) {
            DialogueTrigger ch1event = GameObject.Find("CH1Complete").GetComponent<DialogueTrigger>();
            ch1event.TriggerDialogue();
        }
        if(first == false){
            DialogueTrigger ch1event = GameObject.Find("FirstCH1").GetComponent<DialogueTrigger>();
            ch1event.TriggerDialogue();
        }
        int randomais = UnityEngine.Random.Range(0,3);
        first = true;
        if(randomais == 0){
        EventManager.Instance.SpawnTree2();
        }else if(randomais == 1){
            EventManager.Instance.SpawnTree3();
        }else if(randomais == 2){
            EventManager.Instance.SpawnTree4();
        }
    }
}

public enum GameState
{
    FirstCutscene = 0,
    GenerateGrid = 1,
    SpawnEventDialogue = 2,
    SpawnEventObject = 3,
    InvestigationMode = 4,
    InvestigationMode2 = 5,
    InvestigationMode3 = 6,
    InvestigationMode4 = 7,
    Chapter1 = 8,
    GameOver = 9,
}
