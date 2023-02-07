using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class postScript : MonoBehaviour
{
    public GameObject complete, gameover;
    public GameObject canvas;

    public void win (){
        complete.SetActive(true);
    }

    public void lose(){
        gameover.SetActive(true);
    }

    public void activeCanvas(){
        canvas.SetActive(true);
    }
}
