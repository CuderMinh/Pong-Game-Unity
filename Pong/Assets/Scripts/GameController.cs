using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public GameObject LeftPaddle;
	public GameObject RightPaddle;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		//Left Paddle Controller
		LeftPaddle.GetComponent<Rigidbody> ().velocity = new Vector3 (0f, 0f, 0f);
		if (Input.GetKey (KeyCode.W)) { //If player is pressing up
			LeftPaddle.GetComponent<Rigidbody> ().velocity = new Vector3 (0f, 6f, 0f);
		} else if (Input.GetKey (KeyCode.S)) { //If player is pressing down
			LeftPaddle.GetComponent<Rigidbody> ().velocity = new Vector3 (0f, -6f, 0f);
		} else { 	//pressing neither of the keys
			LeftPaddle.GetComponent<Rigidbody> ().velocity = new Vector3 (0f, 0f, 0f);
		}

		//Right Paddle Controller
		//Default speed of 0 in every frame
		RightPaddle.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);

		//If player is pressing up
		if (Input.GetKey (KeyCode.UpArrow)) {
			RightPaddle.GetComponent<Rigidbody>().velocity = new Vector3(0f, 6f, 0f);
		} 
		//If player is pressing down
		else if (Input.GetKey (KeyCode.DownArrow)) {
			RightPaddle.GetComponent<Rigidbody>().velocity = new Vector3(0f, -6f, 0f);
		} else {
			//pressing neither of the keys
			RightPaddle.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
		}
	}
}
