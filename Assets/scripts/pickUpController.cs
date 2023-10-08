using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpController : MonoBehaviour
{
    //public objectController objectScript;
    public Rigidbody rb;
    public BoxCollider coll;
    public Transform player, objectContainer, playerCamera;

    public float pickUpRange;
    //public float dropForwardForce, dropUpwardForce;

    public bool equipped;
    public static bool slotFull;

    void PickUp()
    {
        equipped = true;
        slotFull = true;
        rb.isKinematic = true;

        //make object a child of the camera and move it to default position
        transform.SetParent(objectContainer);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.Euler(Vector3.zero);
        transform.localScale = Vector3.one;


    }
    void Drop()
    {
        equipped = false;
        slotFull = false;
        rb.isKinematic = false;

        //set parent to null
        transform.SetParent(null);
    }
    // Start is called before the first frame update
    void Start()
    {
        //setup 
        if(!equipped)
        {
            rb.isKinematic = false;
            coll.isTrigger = false;
        }
        if(equipped)
        {
            rb.isKinematic = true;
            coll.isTrigger = true;
            slotFull = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //check if player is in range and "E" is pressed
        Vector3 distanceToPlayer = player.position - transform.position;
        if(!equipped && distanceToPlayer.magnitude <= pickUpRange && Input.GetKeyDown(KeyCode.E) && !slotFull)
        {
            PickUp();
        }
        if(equipped && Input.GetKeyDown(KeyCode.Q))
        {
            Drop();
        }
    }
}
