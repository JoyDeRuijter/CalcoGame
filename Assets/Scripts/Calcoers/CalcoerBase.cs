using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Calcoer", menuName = "Calcoer/Create new Calcoer")]
public class CalcoerBase : ScriptableObject
{
    [Header("- NAME & DESCRIPTION -")]
    [SerializeField] new string name;
    [TextArea] [SerializeField] string description;

    [Space(10)]
    [Header("- TYPE(S) & DISC & RARITY -")]
    [SerializeField] CalcoerType type1;
    [SerializeField] CalcoerType type2;
    [SerializeField] CalcoerDISC disc;
    [Range(0.0f, 10.0f)][SerializeField] float rarity; //0.1 being most rare and 10.0 being most common

    [Space(10)]
    [Header("- BASE STATS -")]
    [SerializeField] int maxHp;
    [SerializeField] int attack;
    [SerializeField] int defense;
    [SerializeField] int spAttack;
    [SerializeField] int spDefense;
    [SerializeField] int speed;

    [Space(10)]
    [Header("- VISUALS -")]
    [SerializeField] Sprite icon;
    [SerializeField] Sprite frontSprite;
    [SerializeField] Sprite backSprite;

    #region Properties

    public string Name { get => name; }
    public CalcoerType Type1 { get => type1; }
    public CalcoerType Type2 { get => type2; }
    public CalcoerDISC Disc { get => disc; }
    public float Rarity { get => rarity; }
    public int MaxHp { get => maxHp;}
    public int Attack { get => attack;}
    public int Defense { get => defense;}
    public int SpAttack { get => spAttack;}
    public int SpDefense { get => spDefense;}
    public int Speed { get => speed;}

    #endregion
}

//IDEA what if the types are just the DISC types???
//Or maybe an extra DISC type?
//SoftSkillTrainer, HardSkillTrainer, PersonalCoach, Recruiter, SalesManager, AccountManager, FieldManager, InzetManager, Directeur, HREmployee, Assistant, Jurist?, Systemmanagement
//Directie, Finance, HR, IT, Legal, Loopbaanbegeleiding, Marketing, Onderwijs, Recruitment, Sales, Secretarieel
public enum CalcoerType
{ 
    NONE,
    COACHING,
    HARDSKILL_EDUCATION,
    SOFTSKILL_EDUCATION,
    FINANCE,
    HR,
    IT,
    LEGAL,
    MANAGEMENT,
    MARKETING,
    RECRUITMENT,
    SALES,
    SECRETARIAL
}

public enum CalcoerDISC
{ 
    D,
    I,
    S,
    C
}
