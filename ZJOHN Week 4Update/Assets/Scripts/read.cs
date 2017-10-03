using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic3Dplus : MonoBehaviour {

	public GameObject mover;
	public int movmentAmt = 1;
	public Vector3 startingPosition;
	public GameObject pie;
    public  GameObject evily;
	public GameObject winspot;
	// Use this for initialization
	void Start () {
		
		startingPosition = mover.transform.position;

	}
	
	// Update is called once per frame
	void Update () {

		if (mover.transform.position.z > 19 ||
			mover.transform.position.x > 19  ||
			mover.transform.position.x < 0)
			 {

			mover.transform.position = startingPosition;
		}

		if (mover.transform.position == 
			new Vector3 (winspot.transform.position.x,
				mover.transform.position.y, 
				winspot.transform.position.z)) {

			Debug.Log ("pie");
			pie.transform.position +=  new Vector3 (0, 500, 0);

		}

        if (mover.transform.position == evily.transform.position)
        {
            Debug.Log("HAIIII");
            mover.transform.position = pie.transform.position;


        }

        if (Input.GetKeyDown(KeyCode.W)) {

			Debug.Log ("true");
			mover.transform.position += new Vector3 (0, 0, movmentAmt);

		} 

		if (Input.GetKeyDown(KeyCode.S)) {

			Debug.Log ("Sea");
			mover.transform.position += new Vector3 (0, 0, -movmentAmt);;

		} 

		if (Input.GetKeyDown(KeyCode.A)) {

			Debug.Log ("Apple");
			mover.transform.position += new Vector3 (-movmentAmt, 0, 0);

		} 

		if (Input.GetKeyDown(KeyCode.D)) {

			Debug.Log ("Dog");
			mover.transform.position += new Vector3 (movmentAmt, 0, 0);

		} 


}
  
}
