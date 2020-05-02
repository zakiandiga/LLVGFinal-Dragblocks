using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class dropHandling : MonoBehaviour, IDropHandler
{
    public int morpherCode;
    public static int morpherText;
    

    void start()
    {
        
    }

    public void OnDrop (PointerEventData eventData)
    {
        //Debug.Log("Dropped at " + morpherCode);
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            morpherText = morpherCode;
            textBehavior.ChangeText();
        }
    }
}
