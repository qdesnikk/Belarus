using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightMenu : MonoBehaviour
{
    [SerializeField] private RectTransform _mapIcons;
    [SerializeField] private RectTransform _regionIcons;

    public void Change(bool isCheckedAnyRegion)
    {
        if (isCheckedAnyRegion)
        {
            _mapIcons.gameObject.SetActive(false);
            _regionIcons.gameObject.SetActive(true);
        }
        else
        {
            _regionIcons.gameObject.SetActive(false);
            _mapIcons.gameObject.SetActive(true);
        }
    }
}
