using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class batang : MonoBehaviour
{
    public GameObject batangs;
    public DialogueTrigger events;
    public GameObject canvasAction;
    public GameObject canvasAction2;
    public GameObject canvasAction3;

    private void OnMouseEnter()
    {
        batangs.SetActive(true);
    }

    private void OnMouseExit()
    {
        batangs.SetActive(false);
    }

    private void OnMouseDown()
    {
        if(SceneManager.GetActiveScene().buildIndex == 1){
            batangs.SetActive(false);
            if(InvestigationGameManager.instance.item == 1){
                GameManager.instance.currentHealth += 5;
                Cursor.SetCursor(null,Vector2.zero,CursorMode.Auto);
                canvasAction.SetActive(true);
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
                GameManager.instance.currentHealth += 2;
                Cursor.SetCursor(null,Vector2.zero,CursorMode.Auto);
                canvasAction2.SetActive(true);
            }
            if(InvestigationGameManager.instance.specialstate == true){
                events.TriggerDialogue();
            }
        }else if(SceneManager.GetActiveScene().buildIndex == 2){
            batangs.SetActive(false);
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
        }else if(SceneManager.GetActiveScene().buildIndex == 3){
            batangs.SetActive(false);
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
                GameManager.instance.currentHealth += 5;
                Cursor.SetCursor(null,Vector2.zero,CursorMode.Auto);
                canvasAction.SetActive(true);
            }else if(InvestigationGameManager.instance.item == 5){
                GameManager.instance.currentHealth += 2;
                Cursor.SetCursor(null,Vector2.zero,CursorMode.Auto);
                canvasAction2.SetActive(true);
            }
            if(InvestigationGameManager.instance.specialstate == true){
                events.TriggerDialogue();
            }
        }else if(SceneManager.GetActiveScene().buildIndex == 4){
            batangs.SetActive(false);
            if(InvestigationGameManager.instance.item == 1){
                GameManager.instance.currentHealth += 5;
                Cursor.SetCursor(null,Vector2.zero,CursorMode.Auto);
                canvasAction.SetActive(true);
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
                GameManager.instance.currentHealth += 2;
                Cursor.SetCursor(null,Vector2.zero,CursorMode.Auto);
                canvasAction2.SetActive(true);
            }
            if(InvestigationGameManager.instance.specialstate == true){
                events.TriggerDialogue();
            }
        }
    }
}
