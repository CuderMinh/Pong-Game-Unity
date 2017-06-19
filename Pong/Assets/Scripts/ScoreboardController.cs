using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //gives access to UI elements
using UnityEngine.SceneManagement;

public class ScoreboardController : MonoBehaviour {

	public static ScoreboardController instance;

	//Text to display on scene
	public Text player1Text;
	public Text player2Text;

//	public Text player1Wins;
//	public Text player2Wins;

	//Variables to get the score of each player
	public int player1Score;
	public int player2Score;

	// Use this for initialization
	void Start () {
		instance = this;
		player1Score = player2Score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Player1Point() {

		if (player1Score <= 10) {
			player1Score += 1;
			player1Text.text = player1Score.ToString ();
		} else if (player1Score == 10) {
			SceneManager.LoadScene (2);
		}
	}

	public void Player2Point() {
		
		if (player2Score <= 10) {
			player2Score += 1;
			player2Text.text = player2Score.ToString ();
		} else if (player2Score == 10) {
			SceneManager.LoadScene (3);
		}
	}



}
