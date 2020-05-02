using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class blockDrag : MonoBehaviour, IPointerDownHandler
{
    public GameObject questionManager;
    private float startX;
    private float startY;

    public bool isDraggable = true;
    public bool isDragged = false;
    
    public static int status = 1;
    public static int wordForm = 1;
    
    void Start()
    {        
        startX = transform.localPosition.x;
        startY = transform.localPosition.y;
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }

    void OnTriggerStay2D (Collider2D col)
    {
        if(col.gameObject.name == "Translate" && Input.GetMouseButtonUp(0))
        {            
            status = 5;
            Debug.Log("Translate");
        }
        if (col.gameObject.name == "Root" && Input.GetMouseButtonUp(0))
        {
            status = 1;
            Debug.Log("Root");
        }
        if (col.gameObject.name == "me-" && Input.GetMouseButtonUp(0))
        {
            status = 2;
            Debug.Log("me");
        }
    }
    
    void Update()
    {        
        /*
        if (isDragged)
        {
            transform.position = (Vector2) Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //GetComponent<BoxCollider2D>().isTrigger = false;
        }
        */

        if (QuestionManager.isRestart == true)
        {
            transform.localPosition = new Vector3(startX, startY, 0);
            status = 1;
            wordForm = status;
            //QuestionManager.isRestart = false;

        }
        
    }

    /*
    void OnMouseDown()
    {        
        if(isDraggable) //&& Input.GetMouseButtonDown(0))
        {
            isDragged = true;
            Debug.Log("isDrag = " + isDragged);
        }        
    }

    void OnMouseUp()
    {
        isDragged = false;
        wordForm = status;
        Debug.Log("isDrag = " + isDragged);
    }
    */
}
