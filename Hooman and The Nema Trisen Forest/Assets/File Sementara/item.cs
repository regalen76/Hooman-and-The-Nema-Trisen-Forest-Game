using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{

    public CursorManager cursorManager;
    public GameObject itemWheel;
    public GameObject botNav;

    private void OnMouseEnter()
    {
        
    }

    private void OnMouseExit()
    {
        
    }

    private void OnMouseDown()
    {
        print(name);
        if(name == "item1"){
            itemWheel.SetActive(false);
            botNav.SetActive(true);
            cursorManager.cursor1();
        }else if(name == "item2"){
            itemWheel.SetActive(false);
            botNav.SetActive(true);
            cursorManager.cursor2();
        }else if(name == "item3"){
            itemWheel.SetActive(false);
            botNav.SetActive(true);
            cursorManager.cursor3();
        }else if(name == "item4"){
            itemWheel.SetActive(false);
            botNav.SetActive(true);
            cursorManager.cursor4();
        }
    }
}
