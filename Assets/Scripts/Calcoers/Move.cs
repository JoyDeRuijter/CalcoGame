using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move
{
    public MoveBase MoveBase { get; set; }
    public int NumOfTimesCanPerform { get; set; }

    public Move(MoveBase _moveBase)
    { 
        MoveBase = _moveBase;
        NumOfTimesCanPerform = MoveBase.NumOfTimesCanPerform;
    }
}
