using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;

    public Queue<string> sentences;

    public GameObject DialogueBox;

    public Text questText;
    public string quest;

    void Start()
    {
        sentences = new Queue<string>();
    }

    void Update()
    {
        
    }

    public void StartDialogue (Dialogue dialogue)
    {
        nameText.text = dialogue.name;

        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            DialogueBox.SetActive(false);
            sentences.Clear();

            questText.text = quest;

            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }
    
}
