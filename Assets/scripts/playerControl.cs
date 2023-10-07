// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class playerControl : MonoBehaviour
// {

//     public float speed = 1;

//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void FixedUpdate()
//     {

//         private Rigidbody _rb;
//         private float jumpForce = 200;

//         //if wasd or arrow keys are pressed, move the player
//         if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.up)) {
//             transform.Translate(Vector3.up * speed);
//         }

//        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.left)) {
//             transform.Translate(Vector3.left * speed);
//         }

//         if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.down)) {
//             transform.Translate(Vector3.down * speed);
//         }

//         if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.right)) {
//             transform.Translate(Vector3.right * speed);
//         }

//         //if space bar is pressed, player jumps
//         if (Input.GetKeyDown(KeyCode.Space)) _rb.AddForce(Vector3.up * jumpForce));


//         //bounds
//         //if(transform.position.y > ) {   //create x, y, and z bounds for the walls
//            // transform.position = new Vector3(transform.position.x, number, transform.position.z);
//        // }

//         //collision with walls
//         var dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical") * speed);
//         vel.y = _rb.velocity.y;
//         _rb.velocity = dir * speed;

        
//     }


// }
