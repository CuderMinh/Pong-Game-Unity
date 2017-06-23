using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //To access scene navigation functions
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

	public static int numberOfPlayers;
	protected Text helpInstruction; //Applicable only to Help Scene

	// Use this for initialization
	void Start () {
		if (helpInstruction == null) {
			return;
		}
	}

	void Update () {
	
			
	}
		
	//Set number of players to 1. Game Controller Object will handle the start game
	public void StartOnePlayerGame() {
		numberOfPlayers = 1;
		SceneManager.LoadScene (1);
	}

	//Set number of players to 2. Game Controller Object will handle the start game
	public void StartTwoPlayerGame() {
		numberOfPlayers = 2;
		SceneManager.LoadScene (1);
	}

	public void QuitGame() {
		Application.Quit ();
	}

	public void DisplayHelp() {
		SceneManager.LoadScene (4);
	}


	public void Rematch() {
		SceneManager.LoadScene (1);
	}

	public void BackToMainMenu() {
		SceneManager.LoadScene (0);
	}

	public void SetOnePlayerInstruction() {
		helpInstruction = GameObject.Find ("InstructionText").GetComponent<Text> ();
		helpInstruction.text = "Player 1: controls the left paddle using 'W' (UP) and 'S' (DOWN) keyboard keys. \n \n " +
		"Computer controls the right paddle. \n \n" +
		"FIRST PLAYER TO SCORE 10 POINTS WINS THE GAME!";
	}

	public void SetTwoPlayerInstruction() {
		helpInstruction = GameObject.Find ("InstructionText").GetComponent<Text> ();
		helpInstruction.text = "Player 1 controls the left paddle using 'W' (UP) and 'S' (DOWN) keyboard keys. \n \n " +
			"Player 2 controls the right paddle using the UP arrow and DOWN arrow keys.\n \n" +
			"FIRST PLAYER TO SCORE 10 POINTS WINS THE GAME!";

	}
}
