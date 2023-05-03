using UnityEngine;

using UnityEngine.UI;

using System.Collections;

public class Izveletaiscilveks : MonoBehaviour

{

	public Dropdown cilveki;

	public static string izveletaisCilveks;

	void Start()

	{

		// Add a listener to the dropdown so we can handle when an option is selected

		cilveki.onValueChanged.AddListener(delegate {

			DropdownValueChanged(cilveki);

		});

	}

	void DropdownValueChanged(Dropdown change)

	{

		// Get the currently selected option from the dropdown

		izveletaisCilveks = cilveki.options[cilveki.value].text;

		Debug.Log("Selected character: " + izveletaisCilveks);

	}

}
