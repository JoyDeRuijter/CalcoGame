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

    private BoxCollider2D boxCol;
    private GameObject player;

    private void Awake()
    {
        boxCol = GetComponent<BoxCollider2D>();
    }

    private void Start()
    {
        player = gameManager.Player;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.gameObject.name == "player")
        //    gameManager.currentArea = this;
    }

    private void Update()
    {
        if (boxCol.bounds.Intersects(player.GetComponent<BoxCollider2D>().bounds))
            gameManager.HandleAreaTracking(this);

        //if (polyCol.bounds.Contains(player.transform.position))
        //    gameManager.currentArea = this;
    }
}
