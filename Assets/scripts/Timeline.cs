/**using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timeline : MonoBehaviour
{
    private bool key;
    private bool lastRoom;
    private bool letter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(key) {
            lastRoom = true;
        }
        else if(lastRoom) {
            letter = true;
        }
    }
}**/
