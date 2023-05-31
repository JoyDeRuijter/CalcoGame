using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ReadOnlyAttribute : PropertyAttribute { }

//Creates a custom property that allows the developers to use [ReadOnlyAttribute] in front of an attribute that makes them readonly in the inspector
[CustomPropertyDrawer(typeof(ReadOnlyAttribute))]
public class ReadOnlyDrawer : PropertyDrawer
{
    public override float GetPropertyHeight(SerializedProperty _property, GUIContent _label) => EditorGUI.GetPropertyHeight(_property, _label, true);

    public override void OnGUI(Rect _position, SerializedProperty _property, GUIContent _label)
    {
        GUI.enabled = false;
        EditorGUI.PropertyField(_position, _property, _label, true);
        GUI.enabled = true;
    }
}
