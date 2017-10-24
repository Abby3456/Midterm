using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Instructions : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.gameObject.GetComponent<Text> ().text = "The Paper Game";
		this.gameObject.GetComponent<Text> ().enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {

			this.gameObject.GetComponent<Text> ().text = "You're job is to count paper into packs of either 25 or 50. \n Press S to count by 2 \n Press A to count by 1 \n Press Space to Create a Package \n Press Tab to Discard a Piece of Damaged Paper \n Press Left Shift to Daydream \n Press Right Shift to Check the Clock \n Press Q to Quit \n Press Enter to Begin and Hold to Check Instructions  \n  \n Do not let the boredom meter (bottom) reach zero! Daydreaming (Left Shift) will increase your interest and prevent you from being fired.";
		} else if (Input.GetKey (KeyCode.Return)) {
			this.gameObject.GetComponent<Text> ().enabled = false;
		} else if (Input.GetKey (KeyCode.LeftControl) || Input.GetKey (KeyCode.LeftCommand)) {
			this.gameObject.GetComponent<Text> ().enabled = true;
		} else if (Input.GetKeyUp (KeyCode.LeftControl) || Input.GetKeyUp (KeyCode.LeftCommand)) {
			this.gameObject.GetComponent<Text> ().enabled = false;
		}

//		if (Input.GetKey (KeyCode.LeftControl)) {
//			this.gameObject.GetComponent<Text> ().enabled = true;
//		} else {
//			this.gameObject.GetComponent<Text> ().enabled = false;
//		}
	}
}
