using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;

public class TeluIzmers : MonoBehaviour {

	public GameObject GarSlaider;

	public GameObject PlatSlaiders;

	public GameObject mainigaisAttels;

	// Use this for initialization

	public void MainitLielumu(){

		float pasreizejaVertiba = GarSlaider.GetComponent<Slider>().value;

		mainigaisAttels.transform.localScale = new Vector2 (mainigaisAttels.transform.localScale.x, 1f * pasreizejaVertiba);

	}
	public void MainitPlatumu(){

		float pasreizejaVertiba = PlatSlaiders.GetComponent<Slider>().value;

		mainigaisAttels.transform.localScale = new Vector2 (1f * pasreizejaVertiba, mainigaisAttels.transform.localScale.y);

	}

}