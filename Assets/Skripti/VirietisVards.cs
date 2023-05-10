using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;

public class VirietisVards : MonoBehaviour {

    public string teksts;

    public string teksts1;

    int sk=0;

    public GameObject button;

    public GameObject ievadesLauks;

    public GameObject tekstaAttelosana;

    public GameObject ievadesLauks1;

    public GameObject tekstaAttelosana1;

    public void UzglabatTekstu(){

        teksts = ievadesLauks.GetComponent<InputField>().text;

        teksts1 = ievadesLauks1.GetComponent<InputField>().text;


        tekstaAttelosana1.GetComponent<Text>().text = "Virietis "+teksts+" ir "+teksts1+" gadus vecs! Viņam ļoti patīk drēbes un viņš sapņo kļūt par modeli, jo domā ka ir ļoti izskatīgs.";

    if(!string.IsNullOrEmpty(teksts) && !string.IsNullOrEmpty(teksts1) && sk==0){
button.SetActive(!button.activeSelf);
sk++;
    }
    
    }



}