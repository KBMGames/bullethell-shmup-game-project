using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupCollected : MonoBehaviour {
	
	public GameObject SoundPlayedOfPickup;
	public int scoreValue;
	public GUIScore gameController;

	void Start()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("GUIScore");
		if(gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent <GUIScore>();
		}
		if(gameControllerObject == null)
		{
			Debug.Log ("cant find GUIScore script");
		}
	}


	void OnTriggerEnter (Collider col){
	
		if (col.gameObject.tag == "Player") {


			Instantiate (SoundPlayedOfPickup,transform.position, transform.rotation);
			gameController.AddScore (scoreValue);
			Destroy (gameObject );
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}

