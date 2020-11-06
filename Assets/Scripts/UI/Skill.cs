using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
[RequireComponent(typeof(Button))]

public class Skill : MonoBehaviour
{
    [SerializeField] private int _addArmor;
    [SerializeField] private int _addAttack;
    [SerializeField] private int _price;
    [SerializeField] private Player _player;

    private Image _image;
    private Button _button;
    private bool _isBuyed;

    public int AddArmor => _addArmor;
    public int AddAttack => _addAttack;
    public int Price => _price;

    private void Awake()
    {
        _image = GetComponent<Image>();
        _button = GetComponent<Button>();
        _isBuyed = false;
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(TryApplySkill);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(TryApplySkill);
    }

    public void ChangeColor(Color color)
    {
        _image.color = color;
    }

    private void TryApplySkill()
    {
        if (!_isBuyed)
        {
            _isBuyed = _player.TryBuySkill(this);
        }
    }
}
