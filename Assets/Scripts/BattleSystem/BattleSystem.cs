using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    [SerializeField] private BattleUnit playerUnit;
    [SerializeField] private BattleUnit enemyUnit;
    [SerializeField] private BattleHud playerHud;
    [SerializeField] private BattleHud enemyHud;

    private void Start()
    {
        SetupBattle();
    }

    public void SetupBattle()
    {
        playerUnit.Setup();
        enemyUnit.Setup();
        playerHud.SetHudData(playerUnit.Calcoer);
        enemyHud.SetHudData(enemyUnit.Calcoer);
    }
}
