using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Import to use pointer events interface
using UnityEngine.EventSystems;

// Attach interface
public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform transform;
    private Canvas canvas;
    private Transform character;
    public GameObject drebes;

    void Start()
    {
        // Access image's transform component and fix its coordinates
        transform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        character = GameObject.FindGameObjectWithTag("cilveks").transform;
    }

    public void OnPointerDown(PointerEventData notikums)
    {
        Debug.Log("Uzspiests uz objekta!");
    }

    public void OnBeginDrag(PointerEventData notikums)
    {
        Debug.Log("Drag sākums!");
        // Make the clothing item a child of the canvas
    }

    public void OnDrag(PointerEventData notikums)
    {
        Debug.Log("Objekts tiek kustināts!");
        transform.anchoredPosition += notikums.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData notikums)
{
    Debug.Log("Drag Pabeigts!");

   
}

}