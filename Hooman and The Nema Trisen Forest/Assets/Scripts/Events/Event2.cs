using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Event2 : BaseEvent
{
    string events = "Tree2";
    void Start()
    {
        PlayerPrefs.SetString("eventnow", events);
    }

    private void OnMouseDown()
    {
        GameManager.instance.ChangeState(GameState.InvestigationMode2);
    }
}

