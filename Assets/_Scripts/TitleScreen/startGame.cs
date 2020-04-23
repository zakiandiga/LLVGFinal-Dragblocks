using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    public void StartGame(int SceneIndex)
    {
        SceneManager.LoadScene(1);
    }
}
