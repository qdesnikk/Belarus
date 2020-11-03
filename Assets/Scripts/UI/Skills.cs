using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skills : Window
{
    [SerializeField] private Button _attackButton1;
    [SerializeField] private Button _attackButton2;
    [SerializeField] private Button _attackButton3;
    [SerializeField] private Button _armorButton1;
    [SerializeField] private Button _armorButton2;
    [SerializeField] private Button _armorButton3;

    private void Start()
    {
        _attackButton1.onClick.AddListener(ChangeColor);
    }

    private void ChangeColor()
    {

    }

    private void AddAttack(int addedAttack)
    {

    }
}
