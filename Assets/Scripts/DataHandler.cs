using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class DataHandler : MonoBehaviour
{  
    
    public GameObject furniture;
    // Start is called before the first frame update
   
   private static DataHandler instance;
    public static DataHandler Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<DataHandler>();
            }
            return instance;
        }
        
    }
}
