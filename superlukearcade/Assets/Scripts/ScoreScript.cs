using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public TMP_Text myScoreText;
    private int ScoreNum;

    // Start is called before the first frame update
    void Start()
    {

        ScoreNum = 0;
        myScoreText.text = "Score : " + ScoreNum;


    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Mycoinball")
        {
            ScoreNum += 1;
            Destroy(other.gameObject);
            myScoreText.text = "Score" + ScoreNum;

        }

       
    }
}
