using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheNoteScript : MonoBehaviour
{

    public GameObject note;
    public GameObject botnav;
    public GameObject[] objects;

    public void openNote(){
        objects[0].SetActive(false);
        objects[1].SetActive(false);
        objects[2].SetActive(false);
        objects[3].SetActive(false);
        botnav.gameObject.SetActive(false);
        note.gameObject.SetActive(true);
    }

    public void closeNote(){
        note.gameObject.SetActive(false);
        botnav.gameObject.SetActive(true);
        objects[0].SetActive(true);
        objects[1].SetActive(true);
        objects[2].SetActive(true);
        objects[3].SetActive(true);
    }
}
