using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testmove : MonoBehaviour {
	public GameObject mover;

	public GameObject enemies;
	public int movmentAmt =1;
	public Vector3 startingPosition;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (mover.transform.position == enemies.transform.position) {
			mover.transform.position = startingPosition;
		}



		if (Input.GetKeyDown (KeyCode.W)) {

			Debug.Log ("true");
			mover.transform.position += new Vector3 (0, 0, movmentAmt);

		} 

		if (Input.GetKeyDown (KeyCode.S)) {

			Debug.Log ("Sea");
			mover.transform.position += new Vector3 (0, 0, -movmentAmt);
			;

		} 

		if (Input.GetKeyDown (KeyCode.A)) {

			Debug.Log ("Apple");
			mover.transform.position += new Vector3 (-movmentAmt, 0, 0);

		} 

		if (Input.GetKeyDown (KeyCode.D)) {

			Debug.Log ("Dog");
			mover.transform.position += new Vector3 (movmentAmt, 0, 0);

	}
}

}
