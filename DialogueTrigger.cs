using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))  //Start Dialogue button
        {
            TriggerDialogue();
        }
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
