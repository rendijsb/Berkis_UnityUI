using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMainitajs : MonoBehaviour {

    // Use this for initialization
    public void Sakums(){
        SceneManager.LoadScene (0, LoadSceneMode.Single);
    }
    public void Virietis(){

            SceneManager.LoadScene (2, LoadSceneMode.Single);

    }
    public void Sieviete(){
        if (Izveletaiscilveks.izveletaisCilveks == "Female") {
            SceneManager.LoadScene (1, LoadSceneMode.Single);
        }
    }
    public void Beigas(){

            SceneManager.LoadScene (4, LoadSceneMode.Single);

    }
    //Metode , kura aizver programmu, ja tā ir izveidota kā .exe
    public void Apturet(){
        Application.Quit();
    }

}