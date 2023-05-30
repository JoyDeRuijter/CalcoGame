using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area : MonoBehaviour
{
    [SerializeField] private int areaID;
    public int AreaID { get => areaID; }

    [SerializeField] private string areaName;
    public string AreaName { get => areaName;}

    [SerializeField] private LayerMask playerLayerMask;
    [SerializeField ]private GameManager gameManager;
    //TODO make sure that not every area needs an objectreference to the gameManager through the inspector
    //Temporary solution because of an unexplained nullreference

    private PolygonCollider2D polyCol;
    private GameObject player;

    private void Awake()
    {
        polyCol = GetComponent<PolygonCollider2D>();
    }

    private void Start()
    {
        player = gameManager.Player;
    }

    private void Update()
    {
        if (polyCol.bounds.Intersects(player.GetComponent<BoxCollider2D>().bounds))
            gameManager.currentArea = this;
    }
}
