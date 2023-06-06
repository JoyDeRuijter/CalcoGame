using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeConventions : MonoBehaviour
{
    //Each class starts with all variables/properties in the following order of accessibility:
    // 1. Start of with the [SerializeField] variables (public variables don't need to be serialized most of the time)
    // 2. Line of whitespace
    // 3. Public variables, grouped by the datatype and 'selfcreated types', like class-instances and enums at the top
    [SerializeField] private string exampleString; 
    [SerializeField] protected int exampleInt;

    public ExampleType exampleType;
    public string exampleString2;
    public string exampleString3;
    public int exampleInt2;
}

public enum ExampleType
{ 
    FIRST_TYPE,
    SECOND_TYPE,
    LAST_TYPE
}

public class ExampleClass
{ 
    // Don't do this in one file, this is just for an example
}