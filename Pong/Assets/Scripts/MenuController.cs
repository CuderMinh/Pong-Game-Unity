using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //To access scene navigation functions

public class MenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartNewGame() {
		SceneManager.LoadScene (1);
	}

	public void QuitGame() {
		Application.Quit ();
	}

	public void DisplayHelp() {
		SceneManager.LoadScene (4);
	}

}
