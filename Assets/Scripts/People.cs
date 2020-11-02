using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class People : MonoBehaviour
{
    [SerializeField] private PopulationSlider _populationSlider;
    [SerializeField] private int _money;
    [SerializeField] private int _attack;
    [SerializeField] private int _armor;
    [SerializeField] private int _population;

    private int _looseCount;
    private UnityEvent OnLooseAllPeople;

    public int Population => _population;
    public int Money => _money;
    public int Attack => _attack;
    public int Armor => _armor;

    private void Awake()
    {
        _population = _populationSlider.Population / 2;
    }

    public int LoosePeople(int damage)
    {
        if (_population > 0)
        {
            int prevPopulation = _population;

            _population -= damage;

            _looseCount = prevPopulation - _population;

        }
        else
        {
            OnLooseAllPeople?.Invoke();
        }

        return _looseCount;
    }

    public void GetPeople(int count)
    {
        if(_population < _populationSlider.Population)
        {
            _population += count;
        }
        else
            return;
    }
}
