using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class colorResults : MonoBehaviour
{
    
  
    public Text title;
    //public Text operations;
     //public Text Numbers;
    
   


    
    public void C_amarelo()
		{  
			 title.color = new Color32(255, 255, 0, 255);
    	
		}  
    public void C_rosa()
		{  
			title.color = new Color(255.0f/0.0f, 0.0f/255.0f, 203.0f/255.0f); 
    	
		}  
     public void C_vermelho()
		{  
			title.color = new Color(255.0f/0.0f, 0.0f/0.0f, 0.0f/255.0f); 
    	
		}  
     public void C_branco()
		{  
			title.color = new Color(255.0f/255.0f, 255.0f/255.0f, 255.0f/255.0f); 
    	
		}  
    public void C_ciano()
		{  
			 title.color = new Color32(68, 144, 233, 255);
    	
		}  
    public void C_azul()
		{  
			 title.color = new Color32(0, 81, 255, 255);
    	
		}  
     public void C_verde()
		{  
			 title.color = new Color32(25, 255, 0, 255);
    	
		}  

    
}