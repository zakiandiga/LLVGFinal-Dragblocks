using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Linq;

public class answerHandler : MonoBehaviour, IDropHandler
{

    public string answerWord;
    public int answerType;


    void Update()
    {
        answerType = textBehavior.newText;
    }

    public void OnDrop(PointerEventData eventData)
    {
        //Debug.Log("Dropped at " + morpherCode);
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            answerWord = eventData.pointerDrag.name;


        }
    }
}
