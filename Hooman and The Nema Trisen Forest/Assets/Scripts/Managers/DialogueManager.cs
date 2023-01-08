using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager Instance;

    public TMP_Text nameText;
    public TMP_Text dialogueText;
    public float typingSpeed;

    public Animator animator;

    private Queue<string> sentences,names;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        sentences = new Queue<string>();
        names = new Queue<string>();
    }

    public void StartDialogue (Dialogue dialogue)
    {
        Time.timeScale = 0;
        animator.SetBool("IsOpen", true);

        names.Clear();

        foreach(string name in dialogue.name){
            names.Enqueue(name);
        }

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string name = names.Dequeue();
        nameText.text = name;

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSecondsRealtime(typingSpeed);
        }
    }

    void EndDialogue()
    {
        Time.timeScale = 1;
        animator.SetBool("IsOpen", false);

        if(SceneManager.GetActiveScene().buildIndex != 2){
            GameManager.instance.ChangeState(GameState.SpawnEventObject);
        }
        if(SceneManager.GetActiveScene().buildIndex == 2)
        {
            if (InvestigationGameManager.instance.state == 1)
            {
                InvestigationGameManager.instance.ChangeState(InvestigationState.FirstSelection);
            }
            else if (InvestigationGameManager.instance.state == 2)
            {
                InvestigationGameManager.instance.ChangeState(InvestigationState.SecondSelection);
            }
            else if (InvestigationGameManager.instance.state == 3)
            {
                InvestigationGameManager.instance.ChangeState(InvestigationState.FinishedSelection);
            }
        }
    }
}
