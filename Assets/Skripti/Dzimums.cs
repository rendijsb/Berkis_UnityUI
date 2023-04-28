using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dzimums : MonoBehaviour {
	//Metode ļauj pārslēgties no UI ainas uz Sākuma ainu
	public void sieviete(){
	SceneManager.LoadScene("Sieviete", LoadSceneMode.Single);
	}
	public void virietis(){
	SceneManager.LoadScene("Virietis", LoadSceneMode.Single);
	}


	//Metode, kura aizver programmu, ja tā ir izveidota kā .exe
	public void Apturet()
	{
		Application.Quit();
	}

	//Pašiem jāuztaisa metode, kas pārslēdz no sākuma uz UI ainu

	
}
