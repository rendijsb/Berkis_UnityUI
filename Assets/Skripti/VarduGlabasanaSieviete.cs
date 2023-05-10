using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;

public class VarduGlabasanaSieviete : MonoBehaviour {

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


        tekstaAttelosana1.GetComponent<Text>().text = "Sieviete "+teksts+" ir "+teksts1+" gadus veca! Viņai ļoti patīk socīalie mēdiji un patīk izmēģināt citu drēbju kombinācijas. Meitene grib kļūt par influenceri.";

    if(!string.IsNullOrEmpty(teksts) && !string.IsNullOrEmpty(teksts1) && sk==0){
button.SetActive(!button.activeSelf);
sk++;
    }
    
    }



}