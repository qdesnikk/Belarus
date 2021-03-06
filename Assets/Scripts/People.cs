﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class People : MonoBehaviour
{
    [SerializeField] private PopulationSlider _populationSlider;
    [SerializeField] private string _name;
    [SerializeField] private int _money;
    [SerializeField] private int _attack;
    [SerializeField] private int _armor;
    [SerializeField] private int _population;

    private int _looseCount;

    public event UnityAction<People> LooseAllPeople;

    public int Population => _population;
    public string Name => _name;
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

            if (damage >= _armor)
            {
                _population -= damage - _armor;
            }

            _looseCount = prevPopulation - _population;
        }
        else
        {
            LooseAllPeople?.Invoke(this);
        }

        return _looseCount;
    }

    public void AddPeople(int count)
    {
        if(_population < _populationSlider.Population)
        {
            _population += count;
            TakeMoney(count);
        }
        else
        {
            return;
        }
    }

    public void AddStats(int addAttack, int addArmor)
    {
        _attack += addAttack;
        _armor += addArmor;
    }

    private void TakeMoney(int count)
    {
        _money += count;
    }

    public bool TryBuySkill(Skill skill)
    {
        if (_money >= skill.Price)
        {
            _money -= skill.Price;

            AddStats(skill.AddAttack, skill.AddArmor);

            skill.ChangeColor(Color.green);

            return true;
        }
        else
        {
            return false;
        }
    }
}
