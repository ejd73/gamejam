using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotCheck : MonoBehaviour
{
   private void Awake()
    {
        
    }

    public void OnPotGrabbed()
    {
        CookingPuzzle.Instance.check();
    }
}
