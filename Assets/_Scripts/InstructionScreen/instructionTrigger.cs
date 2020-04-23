using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instructionTrigger : MonoBehaviour
{
    public Instruction instruction;

    public void TriggerDialogue()
    {
        FindObjectOfType<dialogueManager>().StartDialogue(instruction);
    }
}
