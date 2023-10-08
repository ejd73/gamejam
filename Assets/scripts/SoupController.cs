using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoupController : MonoBehaviour
{
    // Start is called before the first frame update
    private int foodcount;
    
    void Start()
    {
        foodcount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay(Collision collision) {
        if(collision.gameObject.tag == "food") {
            foodcount = foodcount + 1;
        }
    }

    bool CorrectRecipe() {
        if(foodcount == 4) {
            return true;
        }
        return false;
    }


}
