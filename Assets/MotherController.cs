using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MotherController : MonoBehaviour
{
    [SerializeField] UnityEvent onHanded;
    [SerializeField] UnityEvent startDiag;
    // Start is called before the first frame update
    void Start()
    {
        startDiag?.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        bool handedNote = false;
        if (other.transform.tag == "note")
        {
            //put a scene here
            handedNote = true;
            Debug.Log("Handed");
            Destroy(other.gameObject);
            onHanded?.Invoke();
        }
    }
}
