using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	//Multiplayer Option
	public int numberOfPlayers;

	public PaddleController leftPaddle;
	public PaddleController rightPaddle;

	public bool isHumanInput;
	public bool isComputerControlled;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		numberOfPlayers = MenuController.numberOfPlayers;	
		this.StartGame ();
	}

	public void StartGame () {

		leftPaddle.isHumanInput = false;
		leftPaddle.isComputerControlled = false;
		rightPaddle.isComputerControlled = false;
		rightPaddle.isHumanInput = false;


		Debug.Log("GameController");
		if (numberOfPlayers == 1) {
			leftPaddle.isHumanInput = true;
			rightPaddle.isComputerControlled = true;
		} else if (numberOfPlayers == 2) {
			leftPaddle.isHumanInput = true;
			rightPaddle.isHumanInput = true;
		}
	}
}
