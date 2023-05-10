using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Import to use pointer events interface
using UnityEngine.EventSystems;

// Attach interface
public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform transformcomponent;
    private Canvas canvas;
    private Transform cilveks;
    public GameObject drebes;

    void Start()
    {
        // Access image's transform component and fix its coordinates
        transformcomponent = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        cilveks = GameObject.FindGameObjectWithTag("cilveks").transform;
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
        transformcomponent.anchoredPosition += notikums.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData notikums)
{
    if(cilveks){
        transform.SetParent(cilveks);
    }
    Debug.Log("Drag Pabeigts!");


   
}

}