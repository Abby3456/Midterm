using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour {

	// Use this for initialization
	public AudioSource coinNoise;

	public AudioClip[] myRandomSounds;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		//		if (Input.GetKeyDown (KeyCode.Space)) {
		//			coinNoise.Play();
		//		}

		//		if (Input.GetKey (KeyCode.Space) && coinNoise.isPlaying == false) {
		//			coinNoise.Play();
		//		}

		//		if (Input.GetKeyDown (KeyCode.Space)) {
		//			coinNoise.loop = true;
		//			if (coinNoise.isPlaying) {
		//				coinNoise.Stop ();
		//			} else {
		//				coinNoise.Play ();
		//			}
		//		}

		if (Input.GetKeyDown (KeyCode.S) || Input.GetKeyDown (KeyCode.A)) {
			int randomNumber = Random.Range (1, 3);
			coinNoise.clip = myRandomSounds[randomNumber];
			coinNoise.Play ();
		}

		if (Input.GetKeyDown (KeyCode.Space)){
			coinNoise.clip = myRandomSounds[0];
			coinNoise.Play ();
		}

		if (Input.GetKeyDown (KeyCode.Tab)) {
			coinNoise.clip = myRandomSounds [4];
			coinNoise.Play ();
		}
	}
}
