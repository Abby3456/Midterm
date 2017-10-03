using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

	public Transform lookAtTarget;
	public Transform moveToTarget;

	public Transform lookElse;
	public Transform lookOverride;
	public Transform lookHere;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (lookAtTarget != null){
			transform.LookAt (lookAtTarget.position);
		}

		if (moveToTarget != null) {
			Vector3 moveDirection = moveToTarget.position - transform.position;

			if (moveDirection.magnitude > 1f) {

				moveDirection = moveDirection / moveDirection.magnitude; //moveDirection = moveDirection.normalize; | moveDirection = Vector3.Normalize(moveDirection);

			}

			transform.position += moveDirection * Time.deltaTime * 10f;

			if (Input.GetKey (KeyCode.RightShift)) {
				lookAtTarget = lookOverride;	
			} else if (Input.GetKey (KeyCode.LeftShift)) {
				lookAtTarget = lookHere;
			} else if (!Input.GetKey (KeyCode.LeftShift) || !Input.GetKey (KeyCode.RightShift)){
				lookAtTarget = lookElse;
			}

		}

	}
}
