using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class War : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Enemy _enemy;
    [SerializeField] private GameOverWindow _gameOverWindow;

    private int _looseCount;

    private void OnEnable()
    {
        _player.LooseAllPeople += GameOver;
    }

    private void Start()
    {
        StartCoroutine(AttackTimer());
    }

    private void OnDisable()
    {
        _player.LooseAllPeople -= GameOver;
    }

    private void TryToAttack()
    {
        _looseCount = _player.LoosePeople(_enemy.Attack);
        _enemy.GetPeople(_looseCount);

        _looseCount = _enemy.LoosePeople(_player.Attack);
        _player.GetPeople(_looseCount);
    }

    private void GameOver(People people)
    {
        _gameOverWindow.gameObject.SetActive(true);
        _gameOverWindow.GetLoosePlayer(people);
        Time.timeScale = 0;
        
    }

    IEnumerator AttackTimer()
    {
        while (true)
        {
            TryToAttack();

            yield return new WaitForSeconds(1f);
        }
    }


}
