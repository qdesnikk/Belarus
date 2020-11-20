using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBonusSpawner : MonoBehaviour
{
    [SerializeField] private float _generationTime;
    [SerializeField] private Slider _slider;
    [SerializeField] private List<EnemyBonus> _bonuses;
    [SerializeField] private Transform _canvas;

    private Random _random;

    private void Awake()
    {
        _random = new Random();
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        float time = _generationTime;
        _slider.maxValue = time;

        while (time > 0f)
        {
            time -= Time.deltaTime;
            _slider.value = time;
            yield return new WaitForFixedUpdate();
        }

        _bonuses[Random.Range(0, _bonuses.Count)].gameObject.SetActive(true);

        StartCoroutine(Timer());

        yield return null;
    }
}
