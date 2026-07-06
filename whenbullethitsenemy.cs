using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whenbullethitsenemy : MonoBehaviour {

	public AudioSource[] sounds;
	public AudioSource noise1;
	public AudioSource noise2;

	// Use this for initialization
	void Start () {
		sounds = GetComponents<AudioSource>();
		noise1 = sounds[0];
		noise2 = sounds[1];
	}
	
	// Update is called once per frame
	void onTriggerEnter (Collider col) 
		{
			if (col.gameObject.tag == "Enemy") {
			
			noise1.Play ();
			}
		}
	void onTriggerEnter2 (Collider col) 
	{
		if (col.gameObject.tag == "Enemy") {

			noise2.Play ();
		}
	}

	}
