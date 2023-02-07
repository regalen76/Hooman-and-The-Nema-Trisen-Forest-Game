using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event4 : BaseEvent
{
    string events = "Tree4";
    void Start()
    {
        PlayerPrefs.SetString("eventnow", events);
    }

    private void OnMouseDown()
    {
        GameManager.instance.ChangeState(GameState.InvestigationMode4);
    }
}
