using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Sementara : MonoBehaviour
{
    public TMP_Text nameText;

    public string CurrentEvent;

    private void Awake()
    {
        CurrentEvent = PlayerPrefs.GetString("eventnow", "no event");
    }

    void Start()
    {
        nameText.text = CurrentEvent;
    }

}
