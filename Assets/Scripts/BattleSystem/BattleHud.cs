using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BattleHud : MonoBehaviour
{
    [SerializeField] private TMP_Text nameText;
    [SerializeField] private TMP_Text levelText;
    [SerializeField] private HPBar hpBar;

    public void SetHudData(Calcoer _calcoer)
    {
        nameText.text = _calcoer.CalcoerBase.Name;
        levelText.text = "Lvl " + _calcoer.Level;
        hpBar.SetHP((float)(_calcoer.HP / _calcoer.MaxHp));
    }
}
