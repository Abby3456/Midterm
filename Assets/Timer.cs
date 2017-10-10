using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour {

	public Text timerText;

	public Text boredomText;

	public float timerCount = 60.0f;

	public float boredomCount = 15.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		timerText.text = "" + timerCount;
		boredomText.text = "" + boredomCount;

		timerCount -= Time.deltaTime;

		if (timerCount <= 0.0f) {
			timeEnd ();
		}

		//boredomCount -= Time.deltaTime;

		if (boredomCount <= 0.0f) {
			timeEnd ();
		} else if (Input.GetKey (KeyCode.LeftShift)) {
			boredomCount += Time.deltaTime * 2;
		} else if (boredomCount >= 15.1f){
			boredomText.text = "15.00";
			boredomCount = 15.0f;
		} else {
			boredomText.text = "" + boredomCount;
			boredomCount -= Time.deltaTime;
		}

		CountingScript countingScriptComp = GetComponent<CountingScript>();

		//if (timerCount == 0.0f || boredomCount == 0.0f){
		//	countingScriptComp.quit.text = "I QUIT\nPacks Counted: " + countingScriptComp.packsCounted + "\nPacks Counted Correctly: " + countingScriptComp.packsActuallyCounted;
		//}

	}

	void timeEnd(){

		CountingScript countingScriptComp = GetComponent<CountingScript>();

		//if (timerCount <= 0.0f || boredomCount <= 0.0f){
		//	countingScriptComp.quit.text = "I QUIT\nPacks Counted: " + countingScriptComp.packsCounted + "\nPacks Counted Correctly: " + countingScriptComp.packsActuallyCounted;
		//}

		timerText.text = "TIMES UP!";

		/*if (countingScriptComp.papersTotal != 0  || !countingScriptComp.papersTotal < 0){

		}*/

	}
}
