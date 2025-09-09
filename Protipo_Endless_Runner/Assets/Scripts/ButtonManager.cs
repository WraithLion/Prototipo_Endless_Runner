using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public string juego;
    public string inicio;
    public void Restart(string scenename)
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(scenename);

    }
    public void Menu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Menu");
    }
}
