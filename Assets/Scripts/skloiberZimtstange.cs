using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skloiberZimtstange : MonoBehaviour
{
    public bool treffer = false;
    public skloiberManager manager;
    
   
    public void Start()
    {
    
    }
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag == "treffer")
        {
            
            manager.points ++;
            skloiberManager.score = manager.points * 5;

            Destroy(gameObject);
            

            Debug.Log("zaehlen");
            Debug.Log("Hahah dawischt");
        }


        
        if (other.gameObject.tag == "daneben")
        {
            Debug.Log("Hahah nixgwen");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        
    }
    
}
// Zimtstangen brauchen Physiks 
// Glühwein braucht Physiks und einen Wiederstand
// und muss a Triggerpunkt werden
// Zielscheibe braucht trigger punkte

//Mein Spiel muss folgende syntaktischen Elemente beinhalten:
//Array --> Zimtstangen
//If Statements --> Zielscheibe if die Zimtstange trifft a glas
//Methoden --> eh überall