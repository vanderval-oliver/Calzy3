using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class relogio : MonoBehaviour {

 
 public Text hora;

 void Update () {

 hora.text = System.DateTime.Now.ToString("HH:mm");
 
 }
}