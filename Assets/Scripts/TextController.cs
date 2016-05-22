using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class TextController : MonoBehaviour {

	public Text text;
	public Text menuText;
	private enum States {splash, start, animals, simulation, custom, rules};
	private States myState;
	private Stack<States> previousStates;

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
	}

	void state_splash(){
		text.text = "";
		menuText.text = "Press Space To Continue";
		if (Input.GetKeyDown (KeyCode.Space)) {
			print (myState);
			print (previousStates);
			previousStates.Push(myState);
			myState = States.start;
		}

	}

	void state_start(){
			text.text = "It is dark. \r\nHow could life thrive in such a hostile environment."
				+ "\r\nThis place, this world, it reeks of history, billions of years of engineering."
				+ "\r\nHow did I end up here."
				+ "\r\n\r\n\r\nCan I even survive here?";
			
		menuText.text = "R for Rules              A for Animals              S to run Simulation";

		//menu functionality
		if (Input.GetKeyDown (KeyCode.R)) {
			previousStates.Push(myState);
			myState = States.rules;
		} else if (Input.GetKeyDown (KeyCode.A)) {
			previousStates.Push(myState);
			myState = States.animals;
		} else if (Input.GetKeyDown (KeyCode.S)) {
			previousStates.Push(myState);
			myState = States.simulation;
		} 
	
	}

	void state_rules(){
		text.text = "1. There are 25 animals in this section of the Jungle."
			+ "\n2. These animals have been broken into two groups: predators and prey"
			+ "\n3. Every day, each predator initiates a battle for survival with a single animal it encounters at random"
			+ "\n4. Just like real life, the order by which these animals meet, fight and inflict damage is serendipitous. But their strength greatly influences their abilities in battle"
			+ "\n5. If an animal survives a day, sleep revitalizes them and their strength is increased by 1"
			+ "\n6. Days lapse and the fighting continues until there is only one predator left, or no predators left alive";
		menuText.text = "Press Backspace to Return to Main Menu";
	}


	void router() {
		if (myState == States.start) {
			state_start ();
		} else if (myState == States.splash) {
			state_splash ();
		} else if (myState == States.rules) {
			state_rules ();
		}
	}
}
//
//"1. There are 25 animals in this party of the Jungle. Each has a name, species, color, aggressiveness, strength";
//* Create a population of 25 animals. 
//* Each animal has a name, species, color, aggressiveness(bool), strength(int), alive(bool). 
//* At the beginning of each day, increase each animal's strength by 1 and have each aggressive animal chooses another animal to fight.  
//* At some point during the day the animals fight. 
//* The order that the animals fight is random. 
//* Each fight results in a loss of strength/health for both animals equal to a dice roll relative to each animals strength.
//	* Repeat the day until there are no aggressive animals left, or there is only one aggressive animal left. 
