using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Region : MonoBehaviour
{
    [SerializeField] private int _population;
    [SerializeField] private int _bkbPopulation;
    [SerializeField] private int _lukaPopulation;

    private SpriteRenderer _spriteRenderer;
    private Color _defaultColor;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _defaultColor = _spriteRenderer.color;
    }

    public void Check()
    {
        _spriteRenderer.DOColor(Color.gray, 2);
        _spriteRenderer.DOFade(0.7f, 0.5f).SetLoops(-1, LoopType.Yoyo);
    }

    public void Uncheck()
    {
        _spriteRenderer.DOPause();
        _spriteRenderer.color = _defaultColor;
    }
}
