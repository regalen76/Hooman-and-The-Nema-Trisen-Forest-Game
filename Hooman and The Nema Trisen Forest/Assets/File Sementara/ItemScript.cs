using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{

    public GameObject itemWheelCanvas;
    public GameObject BotNav;

    public void TriggerWheel(){
        BotNav.SetActive(false);
        itemWheelCanvas.SetActive(true);
    }
}
