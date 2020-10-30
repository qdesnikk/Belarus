using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Window : MonoBehaviour
{
    public void Close()
    {
        this.gameObject.SetActive(false);
    }
}
