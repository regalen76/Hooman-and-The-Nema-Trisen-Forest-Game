using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2 : MonoBehaviour
{
    
    public GameObject image,arrow,arrow2;

   private void OnMouseEnter()
    {
        image.SetActive(true);
    }

    private void OnMouseExit()
    {
        image.SetActive(false);
    }

    private void OnMouseDown()
    {
        arrow.SetActive(true);
        arrow2.SetActive(false);
    }
}
