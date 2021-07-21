using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scenes : MonoBehaviour
{
    public int Scene;
    public void LoadScene()
    {
        SceneManager.LoadScene(Scene);
        Time.timeScale = 1f;
    }
    public void Exit()
    {
        Application.Quit();
        Debug.Log("вы вышли из игры");
    }
}
