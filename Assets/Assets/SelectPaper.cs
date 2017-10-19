using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPaper : MonoBehaviour {

	public Color normalPaper ;
	public Color damagedPaper;

	public GameObject paperPaper;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		/*if (Input.GetKeyDown (KeyCode.S) || Input.GetKeyDown (KeyCode.DownArrow)) {

			if (Random.Range (1, 100) < 5) {
				paperPaper.GetComponent<Renderer> ().material.color = damagedPaper;
			} else if (Random.Range (1, 100) > 5) {
				paperPaper.GetComponent<Renderer> ().material.color = normalPaper;
			}
		}*/

		if (Input.GetKeyDown (KeyCode.S) || Input.GetKeyDown (KeyCode.DownArrow) || Input.GetKeyDown (KeyCode.A) || Input.GetKeyDown (KeyCode.LeftArrow)) {

			Ray ray = new Ray (Camera.main.transform.position, Camera.main.transform.forward);

			float maxRayDistance = 100f;

			Debug.DrawRay (ray.origin, ray.direction, Color.white);

			RaycastHit rayHit = new RaycastHit ();

			if (Physics.Raycast (ray, out rayHit, maxRayDistance)) {
				if (rayHit.transform.GetComponent<Rigidbody> () != null) {
					Rigidbody paperBody = rayHit.transform.GetComponent<Rigidbody> ();
					GameObject newPaper = Instantiate (paperBody.gameObject, paperBody.position, Quaternion.Euler (0f, 0f, 34.06f)) as GameObject;
					if (Random.Range (1, 100) < 10) {
						newPaper.GetComponent<Renderer> ().material.color = damagedPaper;
					} else {
						newPaper.GetComponent<Renderer> ().material.color = normalPaper;
					}
					paperBody.isKinematic = false;
					paperBody.AddForce ((Vector3.up + Vector3.forward) * 100);
				}
			}
		}

		if (Input.GetKeyDown (KeyCode.Tab)) {
			Ray ray = new Ray (Camera.main.transform.position, Camera.main.transform.forward);

			float maxRayDistance = 100f;

			Debug.DrawRay (ray.origin, ray.direction, Color.white);

			RaycastHit rayHit = new RaycastHit ();

			if (Physics.Raycast (ray, out rayHit, maxRayDistance)) {
				if (rayHit.transform.GetComponent<Rigidbody> () != null) {
					Rigidbody paperBody = rayHit.transform.GetComponent<Rigidbody> ();
					GameObject newPaper = Instantiate (paperBody.gameObject, paperBody.position, Quaternion.Euler (0f, 0f, 34.06f)) as GameObject;
					if (Random.Range (1, 100) < 7) {
						newPaper.GetComponent<Renderer> ().material.color = damagedPaper;
					} else {
						newPaper.GetComponent<Renderer> ().material.color = normalPaper;
					}
					paperBody.isKinematic = false;
					paperBody.AddForce ((Vector3.up + Vector3.back) * 100);
				}
			}
		}
	}
}
