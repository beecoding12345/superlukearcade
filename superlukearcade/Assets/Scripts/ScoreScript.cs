using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public TMP_Text myScoreText;
    public bool shouldReset = false;

    private static int ScoreNum;

    void Start()
    {

        
        


        if (shouldReset == true)
        {
            ScoreNum = 0;
        }

        myScoreText.text = "Score : " + ScoreNum;




    }

   
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Mycoinball")
        {
            ScoreNum += 1;
            Destroy(other.gameObject);
            myScoreText.text = "Score : " + ScoreNum;

        }

       
    }
}
