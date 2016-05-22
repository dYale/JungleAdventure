using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ImageController : GameController {

	
	public Image Animals;
	// Use this for initialization
	void Start () {
		myState = States.splash;
		previousStates = new Stack<States> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Backspace) && previousStates.Count > 0) {
			myState = previousStates.Pop();
		}
		router ();
		renderImages ();
	}

	private void renderImages () {
		if (myState != States.splash) {
			Animals.enabled = false;
		} else {
			Animals.enabled = true;
		}
	}
}