using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textBehavior : MonoBehaviour
{
    TextMeshPro textMesh;
    public string root;
    public string me;
    public string mekan;
    public string mei;
    public string translate;

    public KeyCode rootBu;
    public KeyCode meBu;
    public KeyCode mekanBu;
    public KeyCode meiBu;
    public KeyCode translateBu;

    

    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshPro>();

    }


    // Update is called once per frame
    void Update()
    {
        

        if (blockDrag.wordForm == 1)
        {
            this.textMesh.text = root;
        }
        if (blockDrag.wordForm == 2)
        {
            this.textMesh.text = me;
        }
        if (Input.GetKey(mekanBu))
        {
            this.textMesh.text = mekan;
        }
        if (Input.GetKey(meiBu))
        {
            this.textMesh.text = mei;
        }
        if (blockDrag.wordForm == 5)
        {
            this.textMesh.text = translate;
        }
    }
}
