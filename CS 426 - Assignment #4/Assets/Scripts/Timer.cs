using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.Netcode;

public class Timer : NetworkBehaviour
{
    public float timeRemaining = 180;
    public bool timerIsRunning = false;
    public TMP_Text timeText;
    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
    }

    public void timerStart() {
        timerIsRunning = true;
    }

    void Update()
    {
        //if ((int)OwnerClientId > 0) {
             //timerIsRunning = true;
        //}
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;

                // end the game
                Application.Quit();
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}