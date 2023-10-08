using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private float grabDistance;

    [SerializeField] Transform holdPoint;

    private Raycastable heldObject = null;
    private Transform originalParent;
    private Raycastable hoveredObject;

    private RaycastHit hit;
    private Ray eyeRay;
    private Vector3 screenPointPosition;

    // Start is called before the first frame update
    void Start()
    {
        screenPointPosition = new Vector3 (Screen.width/2, Screen.height/2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(heldObject == null)
        {
            eyeRay = _camera.ScreenPointToRay(screenPointPosition);
            if(Physics.Raycast(eyeRay.origin, eyeRay.direction, out hit, grabDistance))
            {
                Raycastable currentRaycastable =  hit.transform.gameObject.GetComponent<Raycastable>();
                if(currentRaycastable != null)
                {
                    if(hoveredObject != null && hoveredObject.gameObject.GetInstanceID() !=  currentRaycastable.GetInstanceID())
                    {
                        hoveredObject.OnHoverExit();
                        hoveredObject = currentRaycastable;
                        hoveredObject.OnHoverEnter();

                    }
                    else if(hoveredObject == null)
                    {
                        hoveredObject = currentRaycastable;
                        hoveredObject.OnHoverEnter();
                    }
                    
                }
                else
                {
                    if (hoveredObject != null)
                    {
                        hoveredObject.OnHoverExit();
                        hoveredObject = null;
                    }
                }
            }
            else
            {
                if(hoveredObject != null)
                {
                    hoveredObject.OnHoverExit();
                    hoveredObject = null;
                }
            }
        }

        if (hoveredObject != null && heldObject == null)
        {
            if (Input.GetMouseButtonDown(0))
            {
                heldObject = hoveredObject;
                heldObject.OnPickup();
                originalParent = heldObject.transform.parent;

                if(heldObject.grabbable)
                {
                    heldObject.transform.parent = holdPoint;
                    heldObject.transform.localPosition = Vector3.zero;
                    heldObject.transform.localRotation = Quaternion.identity;
                }

            }
        }
        else if (heldObject != null)
        {
            if (Input.GetMouseButtonDown(0))
            {
                heldObject?.OnDrop();

                if(heldObject.grabbable)
                {
                    heldObject.transform.parent = originalParent;
                }

                heldObject = null;
            }
        }
    }
}
