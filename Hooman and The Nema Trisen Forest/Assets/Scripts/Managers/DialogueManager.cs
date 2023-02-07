using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager Instance;

    public TMP_Text nameText;
    public TMP_Text dialogueText;
    public Image imageContainer;
    public Sprite[] characterImage;
    public float typingSpeed;

    public Animator animator;
    public GameObject[] objects;

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

        // if(SceneManager.GetActiveScene().buildIndex == 2){
        //     objects[0].SetActive(false);
        //     objects[1].SetActive(false);
        //     objects[2].SetActive(false);
        //     objects[3].SetActive(false);
        // }

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

        if (name == "Drooid"){
            imageContainer.sprite = characterImage[0];
        }else if (name == "Hooman"){
            imageContainer.sprite = characterImage[1];
        }

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

        if(SceneManager.GetActiveScene().buildIndex == 0 && GameManager.instance.tutor == false){
            GameManager.instance.ChangeState(GameState.SpawnEventObject);
        }
        if(SceneManager.GetActiveScene().buildIndex == 0 && GameManager.instance.first == true && GameManager.instance.currentHealth > 44){
            GameManager.instance.ChangeState(GameState.GameOver);
        }
        if(SceneManager.GetActiveScene().buildIndex == 1 || SceneManager.GetActiveScene().buildIndex == 2 || SceneManager.GetActiveScene().buildIndex == 3 || SceneManager.GetActiveScene().buildIndex == 4)
        {
            objects[0].SetActive(true);
            objects[1].SetActive(true);
            objects[2].SetActive(true);
            objects[3].SetActive(true);
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
