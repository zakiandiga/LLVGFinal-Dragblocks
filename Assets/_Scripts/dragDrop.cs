using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class dragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    //textBehavior TextBehavior;
    //TextMeshPro answerText;
    //string toText;

    public static int status = 1;
    public static int wordForm = 1;

    public GameObject questionManager;
    float startX;
    float startY;

    void start()
    {
        
    }

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        startX = rectTransform.localPosition.x;
        startY = rectTransform.localPosition.y;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = false;
    }
    
    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("Dragging");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //Debug.Log("OnEndDrag");
        canvasGroup.blocksRaycasts = true;
        //toText = dropHandling.morpherText;
        //Debug.Log(toText);
        //textMesh.text = toText;
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("OnPointerDown");
    }
    
    void Update()
    {
        if (QuestionManager.isRestart == true)
        {
            rectTransform.localPosition = new Vector3(startX, startY, 0);
            status = 1;
            wordForm = status;
            //QuestionManager.isRestart = false;

        }
    }
}
