using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayScript : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Game_Scene");
        Debug.Log("Text");
    }

    public void Home()
    {
        SceneManager.LoadScene("Menu");
    }
}