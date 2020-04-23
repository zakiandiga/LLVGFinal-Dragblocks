using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Question
{
    [TextArea(3, 5)]
    public string task;

    public bool isTrue;
    public int answerCode;
    public string answerBlock;

}
