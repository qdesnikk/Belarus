using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class RightMenu : MonoBehaviour
{
    [SerializeField] private RectTransform _rigthMenu;
    [SerializeField] private RectTransform _mapIcons;
    [SerializeField] private RectTransform _regionIcons;

    private Vector2 _startPosition;

    private void Awake()
    {
        _startPosition = _rigthMenu.anchoredPosition;
    }

    public void Change(bool isCheckedAnyRegion)
    {
        _rigthMenu.DOPause();


        if (isCheckedAnyRegion)
        {
            _mapIcons.gameObject.SetActive(false);
            _regionIcons.gameObject.SetActive(true);
            _mapIcons.anchoredPosition = _startPosition;
            _regionIcons.DOAnchorPos(Vector2.zero, 1f);
        }
        else
        {
            _mapIcons.gameObject.SetActive(true);
            _regionIcons.gameObject.SetActive(false);
            _regionIcons.anchoredPosition = _startPosition;
            _mapIcons.DOAnchorPos(Vector2.zero, 1f);
        }


    }
}
