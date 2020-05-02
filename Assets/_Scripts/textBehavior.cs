using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class textBehavior : MonoBehaviour
{
    //public TextMeshPro textAnswer;
    public Text translateText;
    public string root;
    public string me;
    public string mekan;
    public string mei;
    public string translate;
    public static int newText = 1;
    /*
    public KeyCode rootBu;
    public KeyCode meBu;
    public KeyCode mekanBu;
    public KeyCode meiBu;
    public KeyCode translateBu;
    */
    

    // Start is called before the first frame update
    void Start()
    {
        //textAnswer = GetComponent<TextMeshPro>();
        

    }

    public static void ChangeText()
    {
        newText = dropHandling.morpherText;
        
        //MorphingText();
    }
    

    //void MorphingText()


    void Update()
    {
        //Debug.Log(newText);
        if (newText == 1)
        {
            translateText.text = root;
        }

        if (newText == 5)
        {
            translateText.text = translate;
        }

        if (newText == 2)
        {
            translateText.text = me;
        }
        /*if (dropHandling.morpherText == 1)
        {
            textMesh.text = root;
        }

        if (dropHandling.morpherText == 2)
        {
            textMesh.text = me;
        }

        if (dropHandling.morpherText == 3)
        {
            textMesh.text = mekan;
        }

        if (dropHandling.morpherText == 4)
        {
            textMesh.text = mei;
        }

        if (dropHandling.morpherText == 5)
        {
            textMesh.text = translate;
        }*/
        /*
        if (blockDrag.wordForm == 1)
        {
            textMesh.text = root;
        }
        if (blockDrag.wordForm == 2)
        {
            textMesh.text = me;
        }
        if (blockDrag.wordForm == 3)
        {
            textMesh.text = mekan;
        }
        if (blockDrag.wordForm == 4)
        {
            textMesh.text = mei;
        }
        if (blockDrag.wordForm == 5)
        {
            textMesh.text = translate;
        }
        */
    }
}
