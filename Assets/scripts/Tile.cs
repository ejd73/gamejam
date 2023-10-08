using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    private void Awake()
    {
        TilePuzzle.Instance.AddTile();
    }

    public void OnTileGrabbed()
    {
        TilePuzzle.Instance.ReportFoundTile();
    }
}
