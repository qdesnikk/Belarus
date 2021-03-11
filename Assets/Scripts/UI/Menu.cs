using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public void OpenWindow(Window window)
    {
        window.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseWindow(Window window)
    {
        window.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void StartGame()
    {

    }

    public void Exit()
    {
        Application.Quit();
    }
}
