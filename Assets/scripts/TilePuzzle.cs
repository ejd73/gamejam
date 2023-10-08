using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TilePuzzle : MonoBehaviour
{
    public static TilePuzzle Instance;
    
    private int numTiles;

    [SerializeField] private UnityEvent onPuzzleComplete;

    private int numFoundTiles = 0;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
        }

        Instance = this;
    }

    public void AddTile()
    {
        numTiles++;
    }

    public void ReportFoundTile()
    {
        numFoundTiles++;
        if(numFoundTiles >= numTiles)
        {
            onPuzzleComplete?.Invoke();
            Debug.Log("Puzzle complete");
        }
    }
}
