using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stats : Window
{
    [SerializeField] private TMP_Text _playerPopulation;
    [SerializeField] private TMP_Text _playerAttack;
    [SerializeField] private TMP_Text _playerArmor;
    [SerializeField] private TMP_Text _enemyPopulation;
    [SerializeField] private TMP_Text _enemyAttack;
    [SerializeField] private TMP_Text _enemyArmor;
    [SerializeField] private Player _player;
    [SerializeField] private Enemy _enemy;

    private void Update()
    {
        _playerPopulation.text = _player.Population.ToString();
        _playerAttack.text = _player.Attack.ToString();
        _playerArmor.text = _player.Armor.ToString();

        _enemyPopulation.text = _enemy.Population.ToString();
        _enemyAttack.text = _enemy.Attack.ToString();
        _enemyArmor.text = _enemy.Armor.ToString();
    }
}
