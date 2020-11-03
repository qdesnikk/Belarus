using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]

public class EnemyBonus : MonoBehaviour
{
    [SerializeField] private int _bonusAttack;
    [SerializeField] private int _bonusArmor;
    [SerializeField] private Enemy _enemy;

    private Image _image;

    public int BonusAttack => _bonusAttack;
    public int BonusArmor => _bonusArmor;

    private void OnEnable()
    {

        _enemy.AddStats(_bonusAttack, _bonusArmor);

        _image = GetComponent<Image>();
        _image.DOFade(1f, 2f).From(0);

        StartCoroutine(ShowTime());
    }

    IEnumerator ShowTime()
    {
        yield return new WaitForSeconds(3f);
        this.gameObject.SetActive(false);
    } 
}
