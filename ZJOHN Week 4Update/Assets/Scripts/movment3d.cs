using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment3d : MonoBehaviour {
	public GameObject mover;

	public GameObject[] enemies;

	public Vector3 startingPosition;
	public float enemySpeed = 0.1f;
	public GameObject bg;
	public GameObject winspot;
	public int movmentAmt =1;
	public AudioSource moverAudSrc; //audio code 1
	public AudioClip deathsound; 
	public AudioClip winsound;//audio cod 1
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {





		if (mover.transform.position.z > 48 ||
		    mover.transform.position.x > 48||
		    mover.transform.position.x < 0) {

			mover.transform.position = startingPosition;
		}

		if (mover.transform.position ==
		    new Vector3 (winspot.transform.position.x,
			    mover.transform.position.y, 
			    winspot.transform.position.z)) {

			Debug.Log ("pie");
			mover.GetComponent<MeshRenderer> ().material.color = Color.red;
			mover.transform.localScale *= 1.01f; //increases player size contantly on the spot
			moverAudSrc.PlayOneShot (winsound, 0.7f);
			newLevel ();
		} 
		//enemy interaction
		for (int i = 0; i < enemies.Length; i++) {
			
			if (mover.transform.position == enemies [i].transform.position) {
				mover.transform.position = startingPosition; //run into enemy and get reset (enemy was also turned into an int to whenever we put on more numbers 
				moverAudSrc.PlayOneShot (deathsound, 0.7f);
			}

			if (enemies [i].transform.position.x > -2) {
				enemies [i].transform.position += new Vector3 (-enemySpeed, 0, 0);
			} else {
				enemies [i].transform.position = new Vector3 (42, 4, 12);
			}


			//player movement
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
	void newLevel(){
		mover.transform.position = startingPosition; 
		mover.GetComponent<MeshRenderer> ().material.color = new Color(Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f), 1F);
		bg.GetComponent<MeshRenderer> ().material.color = new Color(Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f), 1F);
		enemySpeed += 0.05f;

		for (int i = 0; i < enemies.Length; i++) {
			enemies [i].transform.position = new Vector3 (Random.Range (-2, 3), enemies [i].transform.position.y, Random.Range (1, 6));
		}
	}

}