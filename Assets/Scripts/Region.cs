using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Region : MonoBehaviour
{
    [SerializeField] private int _population;

    private Color _defaultColor;
    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    public void OnCheck()
    {
        _renderer.material.color = Color.red;
    }
}
