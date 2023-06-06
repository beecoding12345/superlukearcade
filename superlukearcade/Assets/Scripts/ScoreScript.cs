using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{

    // varible made for score text and for
    // another varible for reseting and switching for the score
    public TMP_Text myScoreText;
    public bool shouldReset = false;

    private static int ScoreNum;

    void Start()
    {

        
        

        // if statment for when true the
        // score switches and stays the same in the right format below
        if (shouldReset == true)
        {
            ScoreNum = 0;
        }

        myScoreText.text = "Score : " + ScoreNum;




    }

   
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        //if statment for when the player hits the coinabll that has the tag it
        //will add 1 onto the score in the game and it will destroy object on pickup and display the score in game
        if (other.tag == "Mycoinball")
        {
            ScoreNum += 1;
            Destroy(other.gameObject);
            myScoreText.text = "Score : " + ScoreNum;

        }

       
    }
}
