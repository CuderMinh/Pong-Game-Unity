using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right_Paddle_Controller : MonoBehaviour {

	public GameObject RightPaddle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Default speed of 0 in every frame
		RightPaddle.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);

		//If player is pressing up
		if (Input.GetKey (KeyCode.UpArrow)) {
			RightPaddle.GetComponent<Rigidbody>().velocity = new Vector3(0f, 5f, 0f);
		} 
		//If player is pressing down
		else if (Input.GetKey (KeyCode.DownArrow)) {
			RightPaddle.GetComponent<Rigidbody>().velocity = new Vector3(0f, -5f, 0f);
		} else {
			//pressing neither of the keys
			RightPaddle.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
		}
	}
}
