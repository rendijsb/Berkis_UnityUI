using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle : MonoBehaviour {

    public GameObject bottoms;
    public GameObject socks;
    public GameObject dresses;
   public GameObject shoes;
   public GameObject button;

public void ToggleBottoms()
{
    bottoms.SetActive(!bottoms.activeSelf);
}
public void ToggleSocks(){
     socks.SetActive(!socks.activeSelf);
}
public void ToggleDresses(){
     dresses.SetActive(!dresses.activeSelf);
}
public void ToggleShoes(){
     shoes.SetActive(!shoes.activeSelf);
}
public void ToggleB(){
     button.SetActive(!button.activeSelf);
}
}