using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemyShipFive : MonoBehaviour {
	public GameObject deathFx;
	public GameObject Pickup;
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

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "EnemySpecialFive") {
			Instantiate (Pickup,transform.position, transform.rotation);
			Instantiate (deathFx, transform.position, transform.rotation);
			gameController.AddScore (scoreValue);
			Destroy (col.gameObject);
		}
	}


}
