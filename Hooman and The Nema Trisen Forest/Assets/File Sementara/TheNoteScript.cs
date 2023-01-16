using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheNoteScript : MonoBehaviour
{

    public GameObject note;
    public GameObject botnav;

    public void openNote(){
        botnav.gameObject.SetActive(false);
        note.gameObject.SetActive(true);
    }

    public void closeNote(){
        note.gameObject.SetActive(false);
        botnav.gameObject.SetActive(true);
    }
}
