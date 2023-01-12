using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Manager : MonoBehaviour
{
    public int points = 0;
    public GameObject[] stangen;
    public static int score = 0;
    public TMP_Text descriptionText;

    void Start()
    {
        descriptionText.text = "Servus";

    }

    
    void Update()
    {
        
        if (score >=20 )
        {
            
            // (Destroy(stangen[].gameObject));

           // Destroy(gameObject.tag = Finish);
        }

        Debug.Log(score);
        descriptionText.text = "Gratuliere du hast " + score + " Punkte erreicht";
    }
}
