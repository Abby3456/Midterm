using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour {

	public Text timerText;

	public Text boredomText;

	//public Text instructions;

	public float timerCount = 60.0f;

	public float boredomCount = 15.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey (KeyCode.RightShift)){
			timerText.color = new Color  (225f, 128f, 100f, 1f);
		} else {
			timerText.color = new Color (0f, 0f, 0f, 0f);
		}

		timerText.text = "" + timerCount.ToString("F0");
		boredomText.text = "" + boredomCount.ToString("F0");

		timerCount -= Time.deltaTime;

		if (timerCount <= 0.0f) {
			timeEnd ();
		}

		//boredomCount -= Time.deltaTime;

		if (boredomCount <= 0.0f) {
			timeEnd ();
		} else if (Input.GetKey (KeyCode.LeftShift)) {
			boredomCount += Time.deltaTime * 1.5f;
			if (boredomCount > 20f) {
				boredomText.text = "20";
				boredomCount = 20f;
			}
		} //else if (boredomCount > 15f){
			//boredomText.text = "15";
			//boredomCount = 15f;
		//} 
		else {
			boredomText.text = "" + boredomCount.ToString("F0");
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
