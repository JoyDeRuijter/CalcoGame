using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area : MonoBehaviour
{
    [SerializeField] private int areaID;
    public int AreaID { get => areaID; }

    [SerializeField] private string areaName;
    public string AreaName { get => areaName;}

    private GameManager gameManager;
    private BoxCollider2D boxCol;
    private GameObject player;

    private void Awake()
    {
        boxCol = GetComponent<BoxCollider2D>();
    }

    private void Start()
    {
        gameManager = GameManager.Instance;
        player = gameManager.Player;
    }

    private void Update()
    {
        HandleIntersectionWithPlayer();
    }

    //Checks if the boxcollider of the player intersects with the bounds of the boxcollider of this area
    //If it does, it calls the gameManagers function to handle the areatracking and injects itself
    private void HandleIntersectionWithPlayer()
    {
        if (boxCol.bounds.Intersects(player.GetComponent<BoxCollider2D>().bounds))
            gameManager.HandleAreaTracking(this);
    }
}
