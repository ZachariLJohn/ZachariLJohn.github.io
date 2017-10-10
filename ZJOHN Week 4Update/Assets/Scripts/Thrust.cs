using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrust : MonoBehaviour {


	Rigidbody rb;
	public float thrustAMT;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {   // simiar to void update but instead runs on a steady rate so that there is no frame rate breaks when playing the game.
		if (Input.GetKey (KeyCode.W)) {

			rb.AddForce (Vector3.forward * thrustAMT);
		}

		if (Input.GetKey (KeyCode.S)) {

			rb.AddForce (Vector3.back * thrustAMT);
		}
		if (Input.GetKey (KeyCode.D)) {

			rb.AddForce (Vector3.right * thrustAMT);
		}
		if (Input.GetKey (KeyCode.A)) {

			rb.AddForce (Vector3.left * thrustAMT);
		}
}
}