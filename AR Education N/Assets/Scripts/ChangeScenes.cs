using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    // public GameObject startWindow, toShow;
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
