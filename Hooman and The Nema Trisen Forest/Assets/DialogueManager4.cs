using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class DialogueManager4 : MonoBehaviour
{
    public static DialogueManager4 Instance;

    public TMP_Text nameText;
    public TMP_Text dialogueText;

    public float typingSpeed;

    public Animator animator;
    public Animator animator2;
    public GameObject btn;
    public GameObject canvasAction;
    public GameObject[] character;

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

    void Update(){
        if(character[0].activeSelf){
            if(animator2.GetCurrentAnimatorStateInfo(0).IsName("DipBack") && animator2.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f){
                canvasAction.SetActive(false);
            }
        }
    }

    public void StartDialogue (Dialogue dialogue)
    {
        Time.timeScale = 0;

        // if(SceneManager.GetActiveScene().buildIndex == 2){
        //     GameObject.Find("someone1").SetActive(false);
        //     GameObject.Find("someone2").SetActive(false);
        // }

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

        if(name == "Hooman" || name == "Drooid"){
            character[0].SetActive(true);
            character[1].SetActive(true);
        }

        if(character[0].activeSelf && character[1].activeSelf){
            if(name == "Hooman"){
                var tempColor = character[1].GetComponent<Image>().color;
                tempColor.a = 0.5f;
                character[1].GetComponent<Image>().color = tempColor;
                var tempColor2 = character[0].GetComponent<Image>().color;
                tempColor2.a = 1f;
                character[0].GetComponent<Image>().color = tempColor2;
            }else if(name == "Drooid"){
                var tempColor = character[0].GetComponent<Image>().color;
                tempColor.a = 0.5f;
                character[0].GetComponent<Image>().color = tempColor;
                var tempColor2 = character[1].GetComponent<Image>().color;
                tempColor2.a = 1f;
                character[1].GetComponent<Image>().color = tempColor2;
            }
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
        if(SceneManager.GetActiveScene().buildIndex == 0){
            GameObject cutscene = GameObject.Find("actionCanvas");
            cutscene.SetActive(false);
            if(GameManager.instance.currentHealth > 45){
                GameManager.instance.ChangeState(GameState.GameOver);
            }else{
                GameManager.instance.ChangeState(GameState.GenerateGrid);
            }
        }else{
            Time.timeScale = 1;
            btn.SetActive(false);
            character[0].SetActive(false);
            character[1].SetActive(false);
            animator.SetBool("IsOpen", false);
            animator2.SetBool("IsOpen", false);
            GameObject.Find("someone1").SetActive(true);
            GameObject.Find("someone2").SetActive(true);
            GameManager.instance.ChangeState(GameState.Chapter1);
            SceneManager.LoadScene(0);
        }
        
    }
}
