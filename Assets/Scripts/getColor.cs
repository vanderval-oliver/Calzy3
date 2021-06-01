using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class getColor: MonoBehaviour
{
    public Text GetColor ;
  
    public Text title;
   


    

    void Update()
    {
        title.color = GetColor.color;
      
}
}
