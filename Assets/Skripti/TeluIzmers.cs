using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;

public class TeluIzmers : MonoBehaviour {

	public GameObject GarSlaider;

	public GameObject PlatSlaiders;

	public GameObject cilveks;

	public GameObject bikses1;

	// Use this for initialization

	public void MainitLielumu(){

		float pasreizejaVertiba = GarSlaider.GetComponent<Slider>().value;

		cilveks.transform.localScale = new Vector2 (cilveks.transform.localScale.x, 1f * pasreizejaVertiba);

		// bikses1.transform.localScale = new Vector2 (bikses1.transform.localScale.x, 1f * pasreizejaVertiba);

	}
	public void MainitPlatumu(){

		float pasreizejaVertiba = PlatSlaiders.GetComponent<Slider>().value;

		cilveks.transform.localScale = new Vector2 (1f * pasreizejaVertiba, cilveks.transform.localScale.y);

		// bikses1.transform.localScale = new Vector2 (1f * pasreizejaVertiba, bikses1.transform.localScale.y);

	}

}