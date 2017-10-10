using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPaper : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {

			Ray ray = new Ray (Camera.main.transform.position, Camera.main.transform.forward);

			float maxRayDistance = 100f;

			Debug.DrawRay (ray.origin, ray.direction, Color.white);

			RaycastHit rayHit = new RaycastHit ();

			if (Physics.Raycast (ray, out rayHit, maxRayDistance)) {
				if (rayHit.transform.GetComponent<Rigidbody> () != null) {
					Rigidbody paperBody = rayHit.transform.GetComponent<Rigidbody> ();
					Instantiate (paperBody.gameObject, paperBody.position, Quaternion.Euler (0f, 0f, 34.06f));
					paperBody.isKinematic = false;
					paperBody.AddForce ((Vector3.up + Vector3.forward) * 100);
				}
			}
		}
	}
}
