using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _population;
    [SerializeField] private int _money;
    [SerializeField] private float _attack;
    [SerializeField] private float _defence;
    [SerializeField] private float _intellect;

    public int Population => _population;
    public int Money => _money;
    public float Attack => _attack;
    public float Defence => _defence;
    public float Intellect => _intellect;

    public void TakeDamage()
    {

    }
}
