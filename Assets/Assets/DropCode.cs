using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropCode : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		Rigidbody paperBody = GetComponent<Rigidbody>();

		if (Input.GetKeyDown (KeyCode.Space)) {
			paperBody.isKinematic = false;
		} /* else if () {
			paperBody.isKinematic = true;
		} */
	}
}
