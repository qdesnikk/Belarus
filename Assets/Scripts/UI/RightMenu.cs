using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightMenu : MonoBehaviour
{
    public void OpenWindow(Window window)
    {
        window.gameObject.SetActive(true);
    }
}
