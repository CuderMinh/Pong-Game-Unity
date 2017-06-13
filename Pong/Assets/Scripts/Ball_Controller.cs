using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Controller : MonoBehaviour {

	Rigidbody rbComponent; //rigid body attached to Game Object component


	// Use this for initialization
	void Start () {
		rbComponent = GetComponent<Rigidbody>();

		//change the velocity to move the ball
		rbComponent.velocity = new Vector3 (8f, 0f, 0f);

		//Use Random function to set X direction to right or left. 0 for left, 1 for right.
		//Passing Int to the function rounds down the Int, so the max value will always be 1
		int xDirection = Random.Range(0, 2); 
		int yDirection = Random.Range(0, 2);

		Vector3 launchDirection = new Vector3();

		//Check 

		switch (xDirection) { 
		case 0:
			launchDirection.x = -8f;
			break;
		case 1:
			launchDirection.x = 8f;
			break;
		default:
			break;
		}

		switch (yDirection)
		{ 
		case 0:
			launchDirection.y = -8f;
			break;
		case 1:
			launchDirection.y = 8f;
			break;
		default:
			break;

		}

		rbComponent.velocity = launchDirection;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnCollisionEnter (Collision hit) {


		float hitPaddlePosition = transform.position.y - hit.gameObject.transform.position.y;

		switch (hit.gameObject.name) {
		case "TopBoundary":
			rbComponent.velocity = new Vector3 (changeXSpeedDirection(), -8f, 0f);
			break;
		case "BottomBoundary":
			rbComponent.velocity = new Vector3 (changeXSpeedDirection(), 8f, 0f);
			break;
		case "RightPaddle":
			rbComponent.velocity = new Vector3 (-8f, 0f, 0f); //bounces straight to the left
			Debug.Log(hitPaddlePosition);
			if (hitPaddlePosition < -0.5) { //hit lower half of right paddle
				rbComponent.velocity = new Vector3 (-8f, -8f, 0f); //bounce ball back to the left with an upward angle
			} else if (hitPaddlePosition > 0.5) { //hit upper half of the right paddle
				rbComponent.velocity = new Vector3 (-8f, 8f, 0f); //bounce ball back to the left with a downward angle
			}
			break;
		case "LeftPaddle":
			rbComponent.velocity = new Vector3 (8f, 0f, 0f); //bounces straight to the right
			Debug.Log(hitPaddlePosition);
			if (hitPaddlePosition < -0.5) { //hit lower half of right paddle
				rbComponent.velocity = new Vector3 (8f, -8f, 0f); //bounce ball back to the right with an upward angle
			} else if (hitPaddlePosition > 0.5) { //hit upper half of the right paddle
				rbComponent.velocity = new Vector3 (8f, 8f, 0f); //bounce ball back to the right with a downward angle
			}
			break;
		}
	}

	//To bounce to the opposite direction	
	private float changeXSpeedDirection() {
		float speedInXDirection = 0f;

		if (rbComponent.velocity.x > 0f) { //going to the left
			speedInXDirection = 8f; //bounce to right side
		} else if (rbComponent.velocity.x < 0f) { //going to the right
			speedInXDirection = -8f; //bounce to left side
		}
		return speedInXDirection;
	}

}
