using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour {

	//Test Using 1 rigidbody
	public Rigidbody thisRigidBody;
	public float paddleSpeed = 5;


	//Check if Player 1 or 2
	public bool isComputerControlled;
	public bool isHumanInput;

	//Get the reference of the ball using tag. We'll use this to determine which way the computer should go
	public Transform ballTransform;
	public Transform thisPaddleTransform;
	public int paddleNumber;

	// Use this for initialization
	void Start () {
		//instantiate ballTransfor game object
		ballTransform = GameObject.FindGameObjectWithTag("Ball").GetComponent<Transform>();
		//instantiate thisPaddleTransform by getting the transform of the current paddle's GameObject
		thisPaddleTransform = this.gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Paddle Controller Update");
		//Check if current instance of paddle is for human input
		if (isHumanInput) {
			CheckForPlayerInput ();
		} 

		//Check if current instance of paddle is for computer input
		if (isComputerControlled) {
			HandleComputerMovement ();
		}
	}

	void FixedUpdate() {
		CheckForPlayerInput ();
	}

	//Test with computer and player input
	public void CheckForPlayerInput() {
		Debug.Log ("CheckForPlayerInput" + paddleNumber);
		if (paddleNumber == 1) { //Player 1 paddle
			if (Input.GetKey (KeyCode.W)) { //If player is pressing up
				MovePaddleUp ();
			} else if (Input.GetKey (KeyCode.S)) { //If player is pressing down
				MovePaddleDown ();
			}
		} else if (paddleNumber == 2) {
			if (Input.GetKey (KeyCode.UpArrow)) { //If player is pressing up
				MovePaddleUp ();
			} else if (Input.GetKey (KeyCode.DownArrow)) { //If player is pressing down
				MovePaddleDown ();
			}
		}
	}

	public void HandleComputerMovement() {
		//Compare position of the ball and paddle in the Y (up and down) axis.

		//If the ball is higher than the paddle, move the paddle up
		if (ballTransform.position.y > thisPaddleTransform.position.y) {
			MovePaddleUp ();
		}

		if (ballTransform.position.y < thisPaddleTransform.position.y) {
			MovePaddleDown ();
		}
	}

	public void MovePaddleUp() {
		thisRigidBody.AddForce (Vector3.up * paddleSpeed);
//		this.GetComponent<Rigidbody> ().velocity = new Vector3 (0f, 5f, 0f);
	}

	public void MovePaddleDown() {
		thisRigidBody.AddForce (Vector3.down * paddleSpeed);
//		this.GetComponent<Rigidbody> ().velocity = new Vector3 (0f, -5f, 0f);
	}
}
