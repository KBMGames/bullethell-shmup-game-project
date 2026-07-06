using UnityEngine;
using System.Collections;


public class DestroyMyShip : MonoBehaviour {
	public GameObject deathFx;
	void OnTriggerEnter(Collider col) {
		
		if (col.gameObject.tag == "Player") {
			
			Instantiate (deathFx, transform.position, transform.rotation);
			Destroy (col.gameObject, 0.3f );
		}
	}
}


