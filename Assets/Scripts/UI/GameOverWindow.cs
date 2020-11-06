using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverWindow : Window
{
    [SerializeField] TMP_Text _people;

    public void GetLoosePlayer(People people)
    {
        _people.text = people.Name;
    }
}
