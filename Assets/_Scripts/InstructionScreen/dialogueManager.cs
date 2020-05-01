using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class dialogueManager : MonoBehaviour
{
    //public Text nameText; USE IF DISPLAYING SPEAKER NAME
    public Text dialogueText;
    public GameObject playButton;
    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        Debug.Log("Start " + sentences);
        
    }

    public void StartDialogue (Instruction instruction)
    {
        
        //nameText.text = dialogueText.name; USE IF DISPLAYING SPEAKER NAME

        sentences.Clear();

        foreach (string sentence in instruction.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;

    }

    void EndDialogue()
    {
        Debug.Log("End of instruction!");
        playButton.SetActive(true);

        //initiate go to next scene here!
    }
    
    public void NextGame()
    {
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex) + 1);
    }

}
