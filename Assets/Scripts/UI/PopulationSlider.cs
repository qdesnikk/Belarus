using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]

public class PopulationSlider : MonoBehaviour
{
    [SerializeField] private int _population;
    [SerializeField] private Enemy _enemy;

    private Slider _slider;

    public int Population => _population;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        _slider.maxValue = _population;
    }

    private void Update()
    {
        _slider.value = _enemy.Population;
    }
}
