using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TilesRenderPositioning : MonoBehaviour
{
    [SerializeField] private SortingLayer layerBackground;
    [SerializeField] private SortingLayer layerForeground;
    private TilemapRenderer tr;
    private GameObject player;

    private void Awake()
    {
       tr = GetComponent<TilemapRenderer>();
       player = GameManager.Instance.Player;
    }

    private void RenderToForeground()
    {
        Vector3Int belowPlayerPosition = new Vector3Int((int)(player.transform.position.x - 0.5f), (int)(player.transform.position.y + 0.2f), 0);
        TileBase tile;

        try { tile = GetComponent<Tilemap>().GetTile(belowPlayerPosition); }
        catch { tr.sortingLayerName = layerBackground.name;  return; }
        
        tr.sortingLayerName = layerForeground.name;
    }

}
