using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event3 : BaseEvent
{
    string events = "Tree3";
    void Start()
    {
        PlayerPrefs.SetString("eventnow", events);
    }

    private void OnMouseDown()
    {
        GameManager.instance.ChangeState(GameState.InvestigationMode3);
    }
}
