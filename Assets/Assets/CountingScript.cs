using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CountingScript : MonoBehaviour {

	public Text counter;

	public Text packCounter;

	public Text quit;

	public Text totalCounter;

	public int papersTotal;

	public int papersCounted;

	public int packsCounted;

	public int packsActuallyCounted;

	// Use this for initialization
	void Start () {

		counter.text = "0";
		packCounter.text = "0";
		totalCounter.text = "0";

		//papersTotal = 1000;

	}
	
	// Update is called once per frame
	void Update () {

		SelectPaper paperPickingScript = GetComponent<SelectPaper>();

	//	CameraControl camControl = Camera.main.GetComponent<CameraControl>();

		Timer timerScript = GetComponent<Timer>();

	//	if (timerScript.timerCount == 0.0f || timerScript.boredomCount == 0.0f){

	//	}

		if (Input.GetKey (KeyCode.LeftShift) || Input.GetKey (KeyCode.RightShift) || Input.GetKey (KeyCode.Q)) {
			counter.color = new Color (0f, 0f, 0f, 0f);
		} else if ((!Input.GetKey (KeyCode.LeftShift) || !Input.GetKey (KeyCode.RightShift)) && quit.text != "I QUIT\nPacks Counted: " + packsCounted + "\nPacks Counted Correctly: " + packsActuallyCounted){
			counter.color = new Color (225f, 128f, 100f, 1f);
		}

		if (Input.GetKeyDown (KeyCode.S) || Input.GetKeyDown (KeyCode.DownArrow)) {
			papersCounted = papersCounted + 2;
			papersTotal = papersTotal - 2;
		} else if (Input.GetKeyDown (KeyCode.A) || Input.GetKeyDown (KeyCode.LeftArrow)) {
			papersCounted = papersCounted + 1;
			papersTotal = papersTotal - 1;
		} else if (Input.GetKeyDown (KeyCode.Space) && (papersCounted == 25 || papersCounted == 50)) {
			packsActuallyCounted = packsActuallyCounted + 1;
			papersCounted = 0;
			packsCounted = packsCounted + 1;
		} else if (Input.GetKeyDown (KeyCode.Space)) {
			papersCounted = 0;
			packsCounted = packsCounted + 1;
		} 

		if (Input.GetKeyDown (KeyCode.Tab)) {
			papersTotal = papersTotal - 1;
		}

		counter.text = "Papers Counted: " + papersCounted;
		packCounter.text = "Packs Packaged: " + packsCounted;
		totalCounter.text = "Total Paper: " + papersTotal;

		if (Input.GetKeyDown (KeyCode.Q) || timerScript.timerCount <= 0.0f || timerScript.boredomCount <= 0.0f) {
			quit.text = "I QUIT\nPacks Counted: " + packsCounted + "\nPacks Counted Correctly: " + packsActuallyCounted;
			packCounter.color = new Color (0f, 0f, 0f, 0f);
			endCount ();
			if (quit.text == "I QUIT\nPacks Counted: " + packsCounted + "\nPacks Counted Correctly: " + packsActuallyCounted){
			counter.color = new Color (0f, 0f, 0f, 0f);
			}
			if (Input.GetKeyDown (KeyCode.S) || Input.GetKeyDown (KeyCode.DownArrow) || Input.GetKeyDown (KeyCode.A) || Input.GetKeyDown (KeyCode.Space)) {
				endCount ();
			}
		}

		if (papersTotal <= 0 || papersTotal + papersCounted < 50){
			endCount ();
		}

		/*if (quit.text == "I QUIT\nPacks Counted: " + packsCounted + "\nPacks Counted Correctly: " + packsActuallyCounted){

		}*/
	
	}

	void endCount(){
		quit.text = "I QUIT\nPacks Counted: " + packsCounted + "\nPacks Counted Correctly: " + packsActuallyCounted;
		packCounter.color = new Color (0f, 0f, 0f, 0f);
		papersCounted = papersCounted + 0;
		packsCounted = packsCounted + 0;
		packsActuallyCounted = packsActuallyCounted + 0;
	}
}
