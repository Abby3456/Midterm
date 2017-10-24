using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Daydream : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftShift)) {
			this.gameObject.GetComponent<Image> ().enabled = true;
		} else {
			this.gameObject.GetComponent<Image> ().enabled = false;
		}
	}
}
