using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Event", menuName = "Scriptable Event")]
public class ScriptableEvent : ScriptableObject
{
    public Faction Faction;
    public BaseEvent EventPrefab;
}

public enum Faction
{
    first =0,
    second =1,
    third =2,
    fourth =3,
}
