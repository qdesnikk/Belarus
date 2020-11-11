using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTutorial : MonoBehaviour
{
    [SerializeField] private List<GameObject> _windows;
    private int _currentWindow; 

    private void OnEnable()
    {
        _currentWindow = 0;
        _windows[_currentWindow].SetActive(true);
        Time.timeScale = 0;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            NextWindow();
        }
    }

    private void NextWindow()
    {
        _windows[_currentWindow].SetActive(false);
        _currentWindow++;

        if (_currentWindow < _windows.Count)
        {
            _windows[_currentWindow].SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            this.gameObject.SetActive(false);
            return;
        }
    }
}
