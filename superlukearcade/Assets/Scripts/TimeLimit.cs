using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class TimeLimit : MonoBehaviour
{
    // varaible for game losing screen scene and
    // also for the time limit to the game
    public float timeLimit;
    public string GameLosingScreen;
    

    // varaible for the timer display and
    // for the reset for when it switches levels
    private TMP_Text timerDisplay;
    public bool shouldReset = false;

    // start time varible for what the time starts at
    public static float startTime;




    // Start is called before the first frame update
    void Start()
    {
        //displays the timer text on the screen 
        timerDisplay = GetComponent<TMP_Text>();

        
        //  if statement to make sure the timer switches from
        //  level 1 to level 2 and stays the same
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

        //tells you when the time reaches 0 then the
        //game will change to the game losing screen wehn you run out of time
        if (timePassed >= timeLimit)
        {
            SceneManager.LoadScene(GameLosingScreen);
        }


    }
}
