using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class War : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Enemy _enemy;

    private int _looseCount;

    private void Start()
    {
        StartCoroutine(AttackTimer());
    }

    private void TryToAttack()
    {
        _looseCount = _player.LoosePeople(_enemy.Attack);
        _enemy.GetPeople(_looseCount);

        _looseCount = _enemy.LoosePeople(_player.Attack);
        _player.GetPeople(_looseCount);
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
