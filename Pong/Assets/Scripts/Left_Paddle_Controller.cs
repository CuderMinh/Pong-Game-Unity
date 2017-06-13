using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left_Paddle_Controller : MonoBehaviour {

	public GameObject LeftPaddle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Default speed of 0 in every frame
		LeftPaddle.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
		if (Input.GetKey (KeyCode.W)) { //If player is pressing up
			LeftPaddle.GetComponent<Rigidbody>().velocity = new Vector3(0f, 5f, 0f);
		} else if (Input.GetKey (KeyCode.S)) { //If player is pressing down
			LeftPaddle.GetComponent<Rigidbody>().velocity = new Vector3(0f, -5f, 0f);
		} else { 	//pressing neither of the keys
			LeftPaddle.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
		}
	}
}
