using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class RegionStats : MonoBehaviour
{
    private Canvas _stats;

    private void Awake()
    {
        _stats = GetComponent<Canvas>();
    }
}
