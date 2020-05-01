using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instructionTrigger : MonoBehaviour
{
    public Instruction instruction;
    public GameObject nextSentence;
    public GameObject startInstruction;

    public void TriggerDialogue()
    {
        FindObjectOfType<dialogueManager>().StartDialogue(instruction);
        startInstruction.SetActive(false);
        nextSentence.SetActive(true);
    }
}
