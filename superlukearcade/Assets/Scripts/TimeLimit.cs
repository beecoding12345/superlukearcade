using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class TimeLimit : MonoBehaviour
{

    public float timeLimit;
    public string GameLosingScreen;
    

    
    private TMP_Text timerDisplay;
    public bool shouldReset = false;

    public static float startTime;




    // Start is called before the first frame update
    void Start()
    {

        timerDisplay = GetComponent<TMP_Text>();

        

        if (shouldReset == true)
        {
            startTime = Time.time; 
        }







    }

    // Update is called once per frame
    void Update()
    {

        float timePassed = Time.time - startTime;

        timerDisplay.text = Mathf.CeilToInt(timeLimit - timePassed).ToString();

        if (timePassed >= timeLimit)
        {
            SceneManager.LoadScene(GameLosingScreen);
        }


    }
}
