using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Instructions : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.gameObject.GetComponent<Text> ().enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Return)) {
			this.gameObject.GetComponent<Text> ().enabled = false;
		} 
	}
}
