using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CookingPuzzle : MonoBehaviour
{
    public static CookingPuzzle Instance;

    private int ingredients = 4;

    [SerializeField] private UnityEvent onPuzzleComplete;

    private int rightIngred = 0;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
        }

        Instance = this;
    }

    public void rightIng() {
        rightIngred++;
    }

    public void check() {
        if(rightIngred >= ingredients) {
            onPuzzleComplete?.Invoke();
            Debug.Log("Puzzle complete");
        }
    }
}
