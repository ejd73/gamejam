using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoupController : MonoBehaviour
{
    // Start is called before the first frame update
    //private int foodcount;


    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay(Collision collision) {
        if(collision.gameObject.tag == "pot") {
            CookingPuzzle.Instance.rightIng();
        }
    }



}
