using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TilePuzzle : MonoBehaviour
{
    [SerializeField] private GameObject emptyImage;
    [SerializeField] private GameObject fullImage;

    public static TilePuzzle Instance;
    
    private int numTiles = 7;

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

    /*public void AddTile()
    {
        numTiles++;
    }*/

    public void ReportFoundTile()
    {
        numFoundTiles++;
        if(numFoundTiles >= numTiles)
        {
            SwitchImages(false);
            onPuzzleComplete?.Invoke();
            Debug.Log("Puzzle complete");
        }
        else
        {
            SwitchImages(true);
        }
    }

    public void SwitchImages(bool empty)
    {
        if(empty)
        {
            emptyImage.SetActive(true);
            fullImage.SetActive(false);
        }
        if(!empty)
        {
            emptyImage.SetActive(false);
            fullImage.SetActive(true);
        }
    }
}
