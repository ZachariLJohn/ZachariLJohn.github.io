using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideAction : MonoBehaviour {


	AudioSource myAudio;
	public AudioClip DeathSound;
	public AudioClip WinVin;
	// Use this for initialization
	void Start () {
		myAudio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnCollisionEnter(Collision collisionReport) {
		
		Debug.Log ("WHEN WORLDS COLLIDE");
		myAudio.PlayOneShot (DeathSound, 0.7f);
	
		if (collisionReport.gameObject.tag == "Player") {
			myAudio.PlayOneShot (WinVin, 0.7f);

		}
	}
}
