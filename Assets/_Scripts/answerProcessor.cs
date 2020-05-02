using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class answerProcessor : MonoBehaviour
{
    public string answerWord;
    public int answerType;
    

    void Start()
    {
        

    }

    void Update()
    {
        answerType = textBehavior.newText;
        //answerWord = text
    }

    /*
    void Update()
    {
        answerType = blockDrag.wordForm;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        answerWord = col.gameObject.name;
        //Debug.Log("Collided with " + col.gameObject.name);


    }    
    */


}
