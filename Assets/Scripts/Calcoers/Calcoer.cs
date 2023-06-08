using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calcoer
{
    private CalcoerBase calcoerBase;
    private int level;
    private int hp;

    public Calcoer(CalcoerBase _calcoerBase, int _level)
    { 
        calcoerBase = _calcoerBase;
        level = _level;
        hp = MaxHp;
        InitializeMoves();
    }

    #region Properties

    public CalcoerBase CalcoerBase { get => calcoerBase; }
    public int Level { get => level; }
    public int HP { get => hp; }
    public int Attack { get => Mathf.FloorToInt((calcoerBase.Attack * level) / 100f) + 5; }
    public int Defense { get => Mathf.FloorToInt((calcoerBase.Defense * level) / 100f) + 5; }
    public int SpAttack { get => Mathf.FloorToInt((calcoerBase.SpAttack * level) / 100f) + 5; }
    public int SpDefense { get => Mathf.FloorToInt((calcoerBase.SpDefense * level) / 100f) + 5; }
    public int Speed { get => Mathf.FloorToInt((calcoerBase.Speed * level) / 100f) + 5; }
    public int MaxHp { get => Mathf.FloorToInt((calcoerBase.MaxHp * level) / 100f) + 10; }
    public List<Move> Moves { get; set; }

    #endregion

    private void InitializeMoves()
    {
        Moves = new List<Move>();

        foreach (LearnableMove move in calcoerBase.LearnableMoves)
        {
            if (move.Level <= level)
                Moves.Add(new Move(move.MoveBase));
            if (Moves.Count >= 4)
                break;
        }
    }
}