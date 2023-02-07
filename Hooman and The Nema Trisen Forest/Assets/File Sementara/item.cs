using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{

    public CursorManager cursorManager;
    public GameObject itemWheel;
    public GameObject botNav;
    public GameObject[] charaSelect;
    public Sprite[] itemTexture;
    public SpriteRenderer childItemSpriteRenderer;

    public GameObject [] items;

    private int state;

    void Update(){
        if(charaSelect[0].activeSelf){
            items[0].SetActive(true);
            items[1].SetActive(true);
            items[2].SetActive(true);
            childItemSpriteRenderer.sprite = itemTexture[0];
            state = 1;
        }else if(charaSelect[1].activeSelf){
            items[0].SetActive(false);
            items[1].SetActive(false);
            items[2].SetActive(false);
            childItemSpriteRenderer.sprite = itemTexture[1];
            state = 2;
        }
    }

    private void OnMouseDown()
    {
        if(name == "item1"){
            itemWheel.SetActive(false);
            botNav.SetActive(true);
            if(state == 1){
                cursorManager.cursor1();
            }else if(state == 2){
                cursorManager.cursor5();
            }
        }else if(name == "item2"){
            itemWheel.SetActive(false);
            botNav.SetActive(true);
            if(state == 1){
                cursorManager.cursor2();
            }else if(state == 2){
                cursorManager.cursor6();
            }
        }else if(name == "item3"){
            itemWheel.SetActive(false);
            botNav.SetActive(true);
            if(state == 1){
                cursorManager.cursor3();
            }else if(state == 2){
                cursorManager.cursor7();
            }
        }else if(name == "item4"){
            itemWheel.SetActive(false);
            botNav.SetActive(true);
            if(state == 1){
                cursorManager.cursor4();
            }else if(state == 2){
                cursorManager.cursor8();
            }
        }
    }
}
