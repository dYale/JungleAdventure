using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	public Text menuText;
	public Text luisPenis;

	// Use this for initialization
	void Start () {
		text.text = "Predator Vs. Prey - Who Will You Be";
		menuText.text = "AJOSHD";
	}
	
	// Update is called once per frame
	void Update () {
	}


	void welcomeToJungle(){
		if(Input.GetKeyDown(KeyCode.Space)){
			text.text = "It is dark. \r\nHow could life thrive in such a hostile environment."
				+ "\r\nThis place, this world, it reeks of history, billions of years of engineering."
				+ "\r\nHow did I end up here."
				+ "\r\n\r\n\r\nCan I even survive here?";

			menuText.text = "R for Rules              A for Animals              S to run Simulation";
		}
	}
}
