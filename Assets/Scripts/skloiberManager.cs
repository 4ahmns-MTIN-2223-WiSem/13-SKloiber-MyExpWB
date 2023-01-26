using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class skloiberManager : MonoBehaviour
{
    public int points = 0;
    public GameObject[] stangen;
    public static int score = 0;
    public TMP_Text descriptionText;
    public Vector3 newPosition = new Vector3(-0, 1, -15);

    void Start()
    {
        descriptionText.text = "Servus";

        for (int i = 0; i < stangen.Length; i++)
        {
            stangen[i].transform.position = newPosition;

        }
        

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
