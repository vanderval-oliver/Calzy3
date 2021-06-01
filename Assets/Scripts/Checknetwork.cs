using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Checknetwork : MonoBehaviour
{
    
  public GameObject conect; 


 
 
    void Update()
    {
         if (Application.internetReachability!=NetworkReachability.NotReachable)
        {
           
           
           conect.gameObject.SetActive(true);

        }
        else
        {
           
              conect.gameObject.SetActive(false);

       
        }
        
    }
}
