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
    }

    public void cursor2(){
        cursorHotspot = new Vector2(cursorTexture[1].width / 2, cursorTexture[1].height / 2);
        Cursor.SetCursor(cursorTexture[1], cursorHotspot, CursorMode.Auto);
    }

    public void cursor3(){
        cursorHotspot = new Vector2(cursorTexture[2].width / 2, cursorTexture[2].height / 2);
        Cursor.SetCursor(cursorTexture[2], cursorHotspot, CursorMode.Auto);
    }

    public void cursor4(){
        cursorHotspot = new Vector2(cursorTexture[3].width / 2, cursorTexture[3].height / 2);
        Cursor.SetCursor(cursorTexture[3], cursorHotspot, CursorMode.Auto);
    }
}
