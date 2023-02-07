using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class atas : MonoBehaviour
{
    public GameObject atass;
    public DialogueTrigger events;
    public GameObject canvasAction;
    public GameObject canvasAction2;
    public GameObject canvasAction3;

    private void OnMouseEnter()
    {
        atass.SetActive(true);
    }

    private void OnMouseExit()
    {
        atass.SetActive(false);
    }

    private void OnMouseDown()
    {
        if(SceneManager.GetActiveScene().buildIndex == 1){
            atass.SetActive(false);
            if(InvestigationGameManager.instance.item == 1){
                GameManager.instance.currentHealth -= 5;
                Cursor.SetCursor(null,Vector2.zero,CursorMode.Auto);
                canvasAction3.SetActive(true);
            }else if(InvestigationGameManager.instance.item == 2){
                GameManager.instance.currentHealth -= 5;
                Cursor.SetCursor(null,Vector2.zero,CursorMode.Auto);
                canvasAction3.SetActive(true);
            }else if(InvestigationGameManager.instance.item == 3){
                GameManager.instance.currentHealth -= 5;
                Cursor.SetCursor(null,Vector2.zero,CursorMode.Auto);
                canvasAction3.SetActive(true);
            }else if(InvestigationGameManager.instance.item == 4){
                GameManager.instance.currentHealth -= 5;
                Cursor.SetCursor(null,Vector2.zero,CursorMode.Auto);
                canvasAction3.SetActive(true);
            }else if(InvestigationGameManager.instance.item == 5){
                GameManager.instance.currentHealth -= 5;
                Cursor.SetCursor(null,Vector2.zero,CursorMode.Auto);
                canvasAction3.SetActive(true);
            }

            if(InvestigationGameManager.instance.specialstate == true){
                events.TriggerDialogue();
            }
        }else if(SceneManager.GetActiveScene().buildIndex == 2){
            atass.SetActive(false);
            if(InvestigationGameManager.instance.item == 1){
                GameManager.instance.currentHealth -= 5;
                Cursor.SetCursor(null,Vector2.zero,CursorMode.Auto);
                canvasAction3.SetActive(true);
            }else if(InvestigationGameManager.instance.item == 2){
                GameManager.instance.currentHealth += 5;
                Cursor.SetCursor(null,Vector2.zero,CursorMode.Auto);
                canvasAction.SetActive(true);
            }else if(InvestigationGameManager.instance.item == 3){
                GameManager.instance.currentHealth -= 5;
                Cursor.SetCursor(null,Vector2.zero,CursorMode.Auto);
                canvasAction3.SetActive(true);
            }else if(InvestigationGameManager.instance.item == 4){
                GameManager.instance.currentHealth -= 5;
                Cursor.SetCursor(null,Vector2.zero,CursorMode.Auto);
                canvasAction3.SetActive(true);
            }else if(InvestigationGameManager.instance.item == 5){
                GameManager.instance.currentHealth += 2;
                Cursor.SetCursor(null,Vector2.zero,CursorMode.Auto);
                canvasAction2.SetActive(true);
            }
            if(InvestigationGameManager.instance.specialstate == true){
                events.TriggerDialogue();
            }
        }else if(SceneManager.GetActiveScene().buildIndex == 3){
            atass.SetActive(false);
            if(InvestigationGameManager.instance.item == 1){
                GameManager.instance.currentHealth -= 5;
                Cursor.SetCursor(null,Vector2.zero,CursorMode.Auto);
                canvasAction3.SetActive(true);
            }else if(InvestigationGameManager.instance.item == 2){
                GameManager.instance.currentHealth -= 5;
                Cursor.SetCursor(null,Vector2.zero,CursorMode.Auto);
                canvasAction3.SetActive(true);
            }else if(InvestigationGameManager.instance.item == 3){
                GameManager.instance.currentHealth -= 5;
                Cursor.SetCursor(null,Vector2.zero,CursorMode.Auto);
                canvasAction3.SetActive(true);
            }else if(InvestigationGameManager.instance.item == 4){
                GameManager.instance.currentHealth -= 5;
                Cursor.SetCursor(null,Vector2.zero,CursorMode.Auto);
                canvasAction3.SetActive(true);
            }else if(InvestigationGameManager.instance.item == 5){
                GameManager.instance.currentHealth -= 5;
                Cursor.SetCursor(null,Vector2.zero,CursorMode.Auto);
                canvasAction3.SetActive(true);
            }
            if(InvestigationGameManager.instance.specialstate == true){
                events.TriggerDialogue();
            }
        }else if(SceneManager.GetActiveScene().buildIndex == 4){
            atass.SetActive(false);
            if(InvestigationGameManager.instance.item == 1){
                GameManager.instance.currentHealth -= 5;
                Cursor.SetCursor(null,Vector2.zero,CursorMode.Auto);
                canvasAction3.SetActive(true);
            }else if(InvestigationGameManager.instance.item == 2){
                GameManager.instance.currentHealth -= 5;
                Cursor.SetCursor(null,Vector2.zero,CursorMode.Auto);
                canvasAction3.SetActive(true);
            }else if(InvestigationGameManager.instance.item == 3){
                GameManager.instance.currentHealth -= 5;
                Cursor.SetCursor(null,Vector2.zero,CursorMode.Auto);
                canvasAction3.SetActive(true);
            }else if(InvestigationGameManager.instance.item == 4){
                GameManager.instance.currentHealth -= 5;
                Cursor.SetCursor(null,Vector2.zero,CursorMode.Auto);
                canvasAction3.SetActive(true);
            }else if(InvestigationGameManager.instance.item == 5){
                GameManager.instance.currentHealth -= 5;
                Cursor.SetCursor(null,Vector2.zero,CursorMode.Auto);
                canvasAction3.SetActive(true);
            }
            if(InvestigationGameManager.instance.specialstate == true){
                events.TriggerDialogue();
            }
        }
    }
}
