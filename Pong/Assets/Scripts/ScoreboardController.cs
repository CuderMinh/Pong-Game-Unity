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

	//Variables to get the score of each player
	public int player1Score;
	public int player2Score;

	public int scoreToWin = 10;

	// Use this for initialization
	void Start () {
		instance = this;
		player1Score = player2Score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Player1Point() {

		if (player1Score < scoreToWin) {
			player1Score += 1;
			player1Text.text = player1Score.ToString ();
		}

		if (player1Score == scoreToWin) {
			SceneManager.LoadScene (2);
		}
	}

	public void Player2Point() {
		
		if (player2Score < scoreToWin) {
			player2Score += 1;
			player2Text.text = player2Score.ToString ();
		} 

		if (player2Score == scoreToWin) {
			SceneManager.LoadScene (3);
		}
	}



}
