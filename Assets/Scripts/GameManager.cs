using System.Collections;
using System.Collections.Generic;
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
            if (instance = null)
                Debug.LogError("Gamemanager is NULL");
            return instance;
        }
    }

    private void Awake()
    {
        instance = this;
    }
    #endregion

    public GameObject Player;

    // Later hide in inspector
    public Area currentArea;

    [SerializeField] TMP_Text areaText;

    private void Update()
    {
        areaText.text = currentArea.AreaName;
    }
}
