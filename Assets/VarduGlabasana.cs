using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;

public class VarduGlabasana : MonoBehaviour {

	public string teksts;

	public string teksts1;

	public GameObject ievadesLauks;

	public GameObject tekstaAttelosana;

	public GameObject ievadesLauks1;

	public GameObject tekstaAttelosana1;

	public void UzglabatTekstu(){

		teksts = ievadesLauks.GetComponent<InputField>().text;

		tekstaAttelosana.GetComponent<Text>().text = teksts;

		teksts1 = ievadesLauks1.GetComponent<InputField>().text;

		tekstaAttelosana1.GetComponent<Text>().text = teksts1;

		teksts1 = ievadesLauks1.GetComponent<InputField>().text;

		tekstaAttelosana1.GetComponent<Text>().text = teksts1;

	}

}