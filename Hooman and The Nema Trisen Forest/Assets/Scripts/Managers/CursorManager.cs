using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    
    [SerializeField] private Texture2D[] cursorTexture;

    private Vector2 cursorHotspot;

    public void cursor1(){
        cursorHotspot = new Vector2(cursorTexture[0].width / 2, cursorTexture[0].height / 2);
        Cursor.SetCursor(cursorTexture[0], cursorHotspot, CursorMode.Auto);
        InvestigationGameManager.instance.item = 1;
    }

    public void cursor2(){
        cursorHotspot = new Vector2(cursorTexture[1].width / 2, cursorTexture[1].height / 2);
        Cursor.SetCursor(cursorTexture[1], cursorHotspot, CursorMode.Auto);
        InvestigationGameManager.instance.item = 2;
    }

    public void cursor3(){
        cursorHotspot = new Vector2(cursorTexture[2].width / 2, cursorTexture[2].height / 2);
        Cursor.SetCursor(cursorTexture[2], cursorHotspot, CursorMode.Auto);
        InvestigationGameManager.instance.item = 3;
    }

    public void cursor4(){
        cursorHotspot = new Vector2(cursorTexture[3].width / 2, cursorTexture[3].height / 2);
        Cursor.SetCursor(cursorTexture[3], cursorHotspot, CursorMode.Auto);
        InvestigationGameManager.instance.item = 4;
    }

    public void cursor5(){
        cursorHotspot = new Vector2(cursorTexture[4].width / 2, cursorTexture[4].height / 2);
        Cursor.SetCursor(cursorTexture[4], cursorHotspot, CursorMode.Auto);
        InvestigationGameManager.instance.item = 5;
    }

    public void cursor6(){
        cursorHotspot = new Vector2(cursorTexture[5].width / 2, cursorTexture[5].height / 2);
        Cursor.SetCursor(cursorTexture[5], cursorHotspot, CursorMode.Auto);
        InvestigationGameManager.instance.item = 6;
    }

    public void cursor7(){
        cursorHotspot = new Vector2(cursorTexture[6].width / 2, cursorTexture[6].height / 2);
        Cursor.SetCursor(cursorTexture[6], cursorHotspot, CursorMode.Auto);
        InvestigationGameManager.instance.item = 7;
    }

    public void cursor8(){
        cursorHotspot = new Vector2(cursorTexture[7].width / 2, cursorTexture[7].height / 2);
        Cursor.SetCursor(cursorTexture[7], cursorHotspot, CursorMode.Auto);
        InvestigationGameManager.instance.item = 8;
    }
}
