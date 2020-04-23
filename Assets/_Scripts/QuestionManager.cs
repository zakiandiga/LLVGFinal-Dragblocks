using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

public class QuestionManager : MonoBehaviour
{
    public GameObject answerProcessor;
    public GameObject curtainCorrect;
    public GameObject curtainWrong;
    answerProcessor answerProc;
    public static bool isRestart = false;

    public Question[] questions;
    private static List<Question> unansweredQuestion;

    public static Question currentQuestion; //singular, possible to be many?

    [SerializeField]
    private Text taskText;

    [SerializeField]
    private float timeBetweenTask = 3f;

    bool noQuestion = false;
    float currentTime;
    float startingTime = 3f;

    void Start()
    {
        answerProc = answerProcessor.GetComponent<answerProcessor>();
        
        if (unansweredQuestion == null || unansweredQuestion.Count == 0)
        {
            unansweredQuestion = questions.ToList<Question>();
            print("unansweredQuestion was null and initialized!");
        }
        if (unansweredQuestion.Count == 2)
        {
            noQuestion = true;
            //unansweredQuestion = questions.ToList<Question>();
            print("noQuestion is TRUE");
        }

        SetCurrentQuestion();
        Debug.Log(currentQuestion.task + " is " + currentQuestion.isTrue);
    }

    void SetCurrentQuestion()
    {
        int QuestionIndex = Random.Range(0, (unansweredQuestion.Count - 1));
        currentQuestion = unansweredQuestion[QuestionIndex];

        //Testing clearing list after last question assigned to current question
        if (unansweredQuestion.Count == 2)
        {
            unansweredQuestion.Clear();
            print("unansweredQuestion CLEARED!");
            print(unansweredQuestion.Count);
        }
        taskText.text = currentQuestion.task;
    }

    IEnumerator TransitionToNextQuestion()
    {
        unansweredQuestion.Remove(currentQuestion);
        curtainCorrect.SetActive(true);

        yield return new WaitForSeconds(timeBetweenTask);
        curtainCorrect.SetActive(false);
        blockDrag.wordForm = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void CorrectAnswer()
    {

        if (currentQuestion.answerCode == answerProc.answerType &&
            currentQuestion.answerBlock == answerProc.answerWord)
        {
            Debug.Log("CorrectAnswer!");

            if (noQuestion)
            {
                //set delay for loading next scene
                Debug.Log("No more question in this scene!");
                SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex) + 1);
            }
            else
            {
                StartCoroutine(TransitionToNextQuestion());
            }

        }
        if ((currentQuestion.answerCode != answerProc.answerType) ||
            (currentQuestion.answerBlock != answerProc.answerWord))
        {
            Debug.Log("Wrong Answer!");
            currentTime = startingTime;
            
            curtainWrong.SetActive(true);
            isRestart = true;            
        }        
    }

    public void Update()
    {
        if (isRestart)
        {
            currentTime -= 1 * Time.deltaTime;
            print("Count Down " + currentTime);
        }
        if (currentTime <= 0.1f)
        {
            currentTime = startingTime;
            curtainWrong.SetActive(false);
            isRestart = false;
        }
    }


}
