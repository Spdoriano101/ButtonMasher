﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMasher : MonoBehaviour {

    // Data for our class
    public AudioSource clickSound; // sound that will play when we click
    public TextMesh scoreTExt; // display text for the player score
    public TextMesh timerText; // display text for the time remaining
    public float gameLength; // how many seconds will the game last
    public AudioSource gameOverSound; // sound that plays when the timer runs out
    public TextMesh messageText; // display text of a message to the user

    private int score = 0; // the numerical data value of our score
    private float timeRemaining = 0; // Numerical time remaining for game
    private bool gameRunning = false;

    // Use this for initialization
    void Start () {
        Debug.Log("Start method called");

        
	} // End of start
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Start method called again");
 
        timeRemaining = timeRemaining - Time.deltaTime;

        //Update the visual time remaining
        timerText.text = (Mathf.CeilToInt(timeRemaining)).ToString();

        // Check if we have run out of time 
        if (timeRemaining <= 0)
        {

            // Only do this if we just now hit gameover 
            if(gameRunning == true)

            { 
                // Play game over sound
                gameOverSound.Play();

                // Show the player their score
                messageText.text = "Times up! Final Score = " + score.ToString();
            }  // End of IF statement
            

            gameRunning = false;

          
            //Stop out game from going negavtive
            timeRemaining = 0;
        }

	} // End of update()

    // Responds to event from unity that the object ha been clicked

    private void OnMouseDown()
    {

        Debug.Log("OnMouseDown method called");

        //Check if the game is still running
        if(gameRunning == true)
        {

            //Trigger our clicking sound to play
            clickSound.Play();
            // Increase the score by one
            score = score + 1;
            // Update visual score -- changes int score to a string one
            scoreTExt.text = score.ToString();

        } // End of if (gameRunning == true)
     
        else
        {
            // game is not running and we click the button
            gameRunning = true;

            // Set the timer to the full length of our game
            timeRemaining = gameLength;

            messageText.text = "Mash the button!";
        }

    } // End of OnMouseDown()

} // End of button masher class
