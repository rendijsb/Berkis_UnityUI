using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrebjuUzradisana : MonoBehaviour {

    public GameObject Bikses;


public void Toggle()
{
    Bikses.SetActive(!Bikses.activeSelf);
}

}