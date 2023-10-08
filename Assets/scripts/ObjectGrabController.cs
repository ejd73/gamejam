using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGrabController : MonoBehaviour
{


    public GameObject objectContainer;


    //public float dropForwardForce, dropUpwardForce;

    public bool slotFull;
    private bool readyToPickUp; 

    // Start is called before the first frame update
    void Start()
    {
        slotFull = false;
        readyToPickUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)){
            readyToPickUp = true;
        }
        if(Input.GetKeyUp(KeyCode.E)){
            readyToPickUp = false;
        }
        else if(slotFull && Input.GetKeyDown(KeyCode.Q))
        {
            Drop();
        }
    }

    void PickUp()
    {
        slotFull = true;
        gameObject.transform.SetParent(objectContainer.transform);
        transform.localPosition = new Vector3(0f,0.25f, 0.25f);
    }

    void Drop()
    {
        slotFull = false;
        //set parent to null
        transform.SetParent(null);
    }
    void OnTriggerEnter(Collider other){
        //check if player is in range and "E" is pressed
        if(other.tag == "Player" && !slotFull && readyToPickUp)
        {
            PickUp();
        }
    }
}
