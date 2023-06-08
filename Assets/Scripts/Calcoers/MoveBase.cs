using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "Calcoer/Create new move")]
public class MoveBase : ScriptableObject
{
    [SerializeField] new string name;
    [TextArea][SerializeField] string description;
    [SerializeField] CalcoerType type;
    [SerializeField] CalcoerDISC disc;
    [SerializeField] int power;
    [SerializeField] int accuracy;
    [SerializeField] int numOfTimesCanPerform;

    #region Properties

    public string Name { get => name; }
    public string Description { get => description; }
    public CalcoerType Type { get => type; }
    public CalcoerDISC Disc { get => disc; }
    public int Power { get => power; }
    public int Accuracy { get => accuracy; }
    public int NumOfTimesCanPerform { get => numOfTimesCanPerform; }

    #endregion
}
