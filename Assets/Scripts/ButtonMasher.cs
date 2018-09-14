using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMasher : MonoBehaviour {

    // Data for our class
    public AudioSource clickSound; // sound that will play when we click
    public TextMesh scoreTExt; // display text for the player score

    private int score = 0; // the numerical data value of our score



    // Use this for initialization
    void Start () {
        Debug.Log("Start method called");
		
	} // End of start
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Start method called again");
	} // End of update()

    // Responds to event from unity that the object ha been clicked

    private void OnMouseDown()
    {

        Debug.Log("OnMouseDown method called");
        clickSound.Play();
        // Increase the score by one
        score = score + 1;
        // Update visual score -- changes int score to a string one
        scoreTExt.text = score.ToString();
    } // End of OnMouseDown()

} // End of button masher class
