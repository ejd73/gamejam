using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWheelChair : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay(Collision collision) {
        //Debug.Log(collision.gameObject);
        if(collision.gameObject.tag == "wheelchair") {
            //Debug.Log(collision.gameObject);
            if(Input.GetKey(KeyCode.Space)) {
                
                collision.gameObject.GetComponent<FixedJoint>().connectedBody = this.gameObject.GetComponent<Rigidbody>();
            }
            else {
                collision.gameObject.GetComponent<FixedJoint>().connectedBody = null;
            }
        }
    }

}
