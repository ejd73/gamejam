using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopWheelChair : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider collision) {
        //Debug.Log(collision.gameObject);
        if(collision.gameObject.tag == "wheelchair") {
            Debug.Log(collision.gameObject);
            collision.gameObject.GetComponent<FixedJoint>().connectedBody = null;
        }   
    }
}
