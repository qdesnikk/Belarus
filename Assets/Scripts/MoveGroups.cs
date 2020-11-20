using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveGroups : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Enemy _enemy;
    [SerializeField] private GameObject _playerPrefab;
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private List<Transform> _points = new List<Transform>();

    private List<GameObject> _groups = new List<GameObject>();
    private Random _random = new Random();

    private void Start()
    {
        for (int i = 0; i < _points.Count; i++)
        {
            var playerGroup = Instantiate(_playerPrefab, _points[i]);
            _groups.Add(playerGroup);
            var enemyGroup = Instantiate(_enemyPrefab, _points[i]);
            _groups.Add(enemyGroup);
        }

        StartCoroutine(RandomMove());
    }

    private IEnumerator RandomMove()
    {
        while (true)
        {
            foreach (var group in _groups)
            {
                group.transform.DOMove(_points[Random.Range(0, _points.Count)].position, 2f);
            }

            yield return new WaitForSeconds(2f);
        }
    }
}
