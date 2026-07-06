using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenFlashOnHit : MonoBehaviour {

	public float flashLenght;
	private float flashCounter;

	private Renderer rend;
	private Color storedColor;

	void Start (){
		rend = GetComponent<Renderer> ();
		storedColor = rend.material.GetColor ("_Color");
	}

	void update (){
	
		if (flashCounter > 0) {
			flashCounter -= Time.deltaTime;
			if (flashCounter <= 0) {
				rend.material.SetColor ("_Color", storedColor);

			}
		}
	}

	public void OnTriggerEnter(Collider col){
	
		if (col.gameObject.tag == "EnemyBUllet") {
			flashCounter = flashLenght;
			rend.material.SetColor ("_Color", Color.red);


		}
	
	}
			

}