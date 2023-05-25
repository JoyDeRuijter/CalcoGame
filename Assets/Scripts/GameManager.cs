using System.Collections;
using System.Collections.Generic;
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

    //Player property
    [SerializeField] private GameObject player;
    public GameObject Player { get => player;}
}
