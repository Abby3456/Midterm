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

	public int addThis;

	bool isEnterPressed;

	bool isSpacePressed;

	// Use this for initialization
	void Start () {

		addThis = 1;

		isSpacePressed = false;

		isEnterPressed = false;

		counter.text = "Paper Counted";
		packCounter.text = "Packs Counted";
		totalCounter.text = "Total Paper";

		//papersTotal = 1000;

	}
	
	// Update is called once per frame
	void Update () {

		SelectPaper paperPickingScript = GetComponent<SelectPaper> ();

		//	CameraControl camControl = Camera.main.GetComponent<CameraControl>();

		Timer timerScript = GetComponent<Timer> ();

		//	if (timerScript.timerCount == 0.0f || timerScript.boredomCount == 0.0f){

		//	}

		if (Input.GetKeyDown (KeyCode.Return)) {
			isEnterPressed = true;
		}

		if (isEnterPressed){
		if (Input.GetKey (KeyCode.LeftShift) || Input.GetKey (KeyCode.RightShift) || Input.GetKey (KeyCode.Q)) {
			counter.color = new Color (0f, 0f, 0f, 0f);
		} else if ((!Input.GetKey (KeyCode.LeftShift) || !Input.GetKey (KeyCode.RightShift)) && quit.text != "I QUIT\nPacks Counted: " + packsCounted + "\nPacks Counted Correctly: " + packsActuallyCounted) {
			counter.color = new Color (225f, 128f, 100f, 1f);
		}

		if (Input.GetKeyDown (KeyCode.S) || Input.GetKeyDown (KeyCode.DownArrow)) {
			papersCounted = papersCounted + 2;
			papersTotal = papersTotal - 2;
		} else if (Input.GetKeyDown (KeyCode.A) || Input.GetKeyDown (KeyCode.LeftArrow)) {
			papersCounted = papersCounted + 1;
			papersTotal = papersTotal - 1;
		} else if (Input.GetKeyDown (KeyCode.Space) && (papersCounted == 25 || papersCounted == 50)) {
				isSpacePressed = true;
			packsActuallyCounted = packsActuallyCounted + 1;
			papersCounted = 0;
				packsCounted = packsCounted + addThis;
		} else if (Input.GetKeyDown (KeyCode.Space)) {
				isSpacePressed = true;
			papersCounted = 0;
				packsCounted = packsCounted + addThis;
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
				addThis = 0;
			if (quit.text == "I QUIT\nPacks Counted: " + packsCounted + "\nPacks Counted Correctly: " + packsActuallyCounted) {
				counter.color = new Color (0f, 0f, 0f, 0f);
			}
			if (Input.GetKeyDown (KeyCode.S) || Input.GetKeyDown (KeyCode.DownArrow) || Input.GetKeyDown (KeyCode.A) || Input.GetKeyDown (KeyCode.Space)) {
				endCount ();
					addThis = 0;
			}
		}

		if (papersTotal <= 0 || papersTotal + papersCounted < 50) {
			endCount ();
				addThis = 0;
		}

			if (isSpacePressed = false) {
				addThis = 0;
			}

		/*if (quit.text == "I QUIT\nPacks Counted: " + packsCounted + "\nPacks Counted Correctly: " + packsActuallyCounted){

		}*/

//			if (quit.text == "I QUIT\nPacks Counted: " + packsCounted + "\nPacks Counted Correctly: " + packsActuallyCounted && Input.GetKeyDown (KeyCode.Space)) {
//				isEnterPressed = false;
//			}
		}
	}

	void endCount(){
		//quit.text = "I QUIT\nPacks Counted: " + packsCounted + "\nPacks Counted Correctly: " + packsActuallyCounted; 
		isSpacePressed = false;
		packCounter.color = new Color (0f, 0f, 0f, 0f);
		papersCounted = papersCounted + 0;
		packsCounted = packsCounted + 0;
		packsActuallyCounted = packsActuallyCounted + 0;

		Timer timerScript = GetComponent<Timer> ();

		if ((packsActuallyCounted > 15) && (packsActuallyCounted < 33)) {
			quit.text = "I QUIT\nPacks Counted: " + packsCounted + "\nPacks Counted Correctly: " + packsActuallyCounted;
		} else if ((packsActuallyCounted < 16) || ((timerScript.boredomCount <= 0f) && (packsActuallyCounted < 16))) {
			quit.text = "YOU'RE FIRED\nPacks Counted: " + packsCounted + "\nPacks Counted Correctly: " + packsActuallyCounted;
		}
	}
}
