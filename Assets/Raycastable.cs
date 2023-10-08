using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Raycastable : MonoBehaviour
{
    [SerializeField] private UnityEvent onHoverEnter;
    [SerializeField] private UnityEvent onHoverExit;

    [SerializeField] private UnityEvent onPickup;
    [SerializeField] private UnityEvent onDrop;

    public bool grabbable;

    public void OnHoverEnter()
    {
        onHoverEnter?.Invoke();
    }

    public void OnHoverExit()
    {
        onHoverExit?.Invoke();
    }

    public void OnPickup()
    {
        onPickup?.Invoke();
    }

    public void OnDrop()
    {
        onDrop?.Invoke();
    }
}
