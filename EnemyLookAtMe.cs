using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLookAtMe : MonoBehaviour {

	private Rigidbody myRB;
	public PlayerController thePlayer;

	// Use this for initialization
	void Start () {
		myRB = GetComponent<Rigidbody>();
		thePlayer = FindObjectOfType<PlayerController>();

	}

	void FixedUpdate(){


	}


	void Update () 
	{

		transform.LookAt (thePlayer.transform.position);

	}
}
