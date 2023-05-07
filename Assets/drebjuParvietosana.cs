﻿using System.Collections;

using System.Collections.Generic;

using UnityEngine;

//Importē, lai lietotu pointer darbību interfeisu

using UnityEngine.EventSystems;

//Piesaista interfeisu

public class drebjuParvietosana : MonoBehaviour,IPointerDownHandler, IBeginDragHandler, IDragHandler,IEndDragHandler {

	private RectTransform transformKomponente;

	public Canvas kanva;

	// Use this for initialization

	void Start () {

		//startējot automātiski piekļūst attēla transform komponentei un piefiksē kādas koordinātās attēls atrodas

		transformKomponente = GetComponent<RectTransform>();

	}

	public void OnPointerDown(PointerEventData notikums){

		Debug.Log ("Izdarīts peles klikšķis uz objekta!");

	}

	public void OnBeginDrag(PointerEventData notikums){

		Debug.Log ("Uzsākta objekta vilkšana!");

	}

	public void OnDrag(PointerEventData notikums){

		Debug.Log ("Notiek objekta pāŗvietošana!");

		transformKomponente.anchoredPosition += notikums.delta / kanva.scaleFactor;

	}

	public void OnEndDrag(PointerEventData notikums){

		Debug.Log ("Pabeigta objekta vilkšana!");

	}

}