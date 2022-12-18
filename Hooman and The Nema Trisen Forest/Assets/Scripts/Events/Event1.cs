using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Event1 : BaseEvent
{
    string events = "Wolf";
    void Start()
    {
        PlayerPrefs.SetString("eventnow", events);
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene(1);
    }
}
