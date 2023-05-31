using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region instance
    private static GameManager instance;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
                Debug.LogError("Gamemanager is NULL");
            return instance;
        }
    }

    private void Awake()
    {
        instance = this;
    }
    #endregion

    [Header("- PUBLIC REFERENCES -")]
    public GameObject Player;

    [Space(10)]
    [Header("- PRIVATE REFERENCES -")]
    [SerializeField] private TMP_Text areaText;

    [Space(10)]
    [Header("- EDITABLE SETTINGS -")]
    [SerializeField] private Area startArea;

    [Space(10)]
    [Header("- READONLY ATTRIBUTES - ")]
    [ReadOnlyAttribute, SerializeField] private Area currentArea;

    private void Start()
    {
        currentArea = startArea;
    }

    // Is called from the Area class when an area intersects with the player and then injects itself as parameter
    // Sets the currentArea and updates the areaText
    public void HandleAreaTracking(Area _area)
    {
        if (currentArea != _area)
        { 
            currentArea = _area;
            areaText.text = currentArea.AreaName;
        }
    }
}
