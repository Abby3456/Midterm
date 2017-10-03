using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CountingScript : MonoBehaviour {

	public Text counter;

	public Text packCounter;

	public Text quit;

	public int papersCounted;

	public int packsCounted;

	public int packsActuallyCounted;

	// Use this for initialization
	void Start () {

		counter.text = "0";
		packCounter.text = "0";

	}
	
	// Update is called once per frame
	void Update () {

	//	CameraControl camControl = Camera.main.GetComponent<CameraControl>();

		if (Input.GetKey (KeyCode.LeftShift)) {
			counter.color = new Color (0f, 0f, 0f, 0f);
		} else {
			counter.color = new Color (225f, 128f, 100f, 1f);
		}

		if (Input.GetKeyDown (KeyCode.S) || Input.GetKeyDown (KeyCode.DownArrow)) {
			papersCounted = papersCounted + 2;
		}
		else if (Input.GetKeyDown (KeyCode.A) || Input.GetKeyDown (KeyCode.LeftArrow)) {
			papersCounted = papersCounted + 1;
		}
		else if (Input.GetKeyDown (KeyCode.Space) && papersCounted == 25){
			packsActuallyCounted = packsActuallyCounted + 1;
			papersCounted = 0;
			packsCounted = packsCounted + 1;
		}
		else if (Input.GetKeyDown (KeyCode.Space)) {
			papersCounted = 0;
			packsCounted = packsCounted + 1;
		}
			counter.text = "Papers Counted: " + papersCounted;
			packCounter.text = "Packs Packaged: " + packsCounted;

		if (Input.GetKeyDown (KeyCode.Q)) {
			quit.text = "I QUIT\nPacks Counted: " + packsCounted + "\nPacks Correctly Counted: " + packsActuallyCounted;
			if (Input.GetKeyDown (KeyCode.S) || Input.GetKeyDown (KeyCode.DownArrow) || Input.GetKeyDown (KeyCode.A) || Input.GetKeyDown (KeyCode.Space)) {
				papersCounted = papersCounted;
				packsCounted = packsCounted;
				packsActuallyCounted = packsActuallyCounted;
			}
		}
	}
}
