using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sing : MonoBehaviour {

   public  GameObject minion;

     void OnTriggerEnter()
    {

	
        GetComponent<BoxCollider>().enabled = false;
        Generatos.start = true;
        Health.start = true;
        boss1generator.start = true;
        

    }
}
