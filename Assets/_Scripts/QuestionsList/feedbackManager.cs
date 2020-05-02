using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class feedbackManager : MonoBehaviour
{
    //public Text nameText; USE IF DISPLAYING SPEAKER NAME
    public Text dialogueText;
    public GameObject curtainWrong;
    //private List<string> feedbacks;
    //public GameObject QuestionManager;
    [TextArea(3, 5)]
    public string[] feedbacks;
    int questionIndex;

    void FeedbackText()
    {
        if(QuestionManager.isRestart == true)
        {
            questionIndex = QuestionManager.QuestionIndexSend;
            dialogueText.text = feedbacks[questionIndex];
        }

    }

    void Update()
    {
        //FeedbackText();
        questionIndex = QuestionManager.QuestionIndexSend;
        dialogueText.text = feedbacks[questionIndex];
    }
    
    // Start is called before the first frame update



}
