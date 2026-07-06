using UnityEngine;
using System.Collections;

public class DestroyMyShield : MonoBehaviour {
	
	public GameObject deathFx;


	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "MyShield") {
			
			Instantiate (deathFx, transform.position, transform.rotation);

			Destroy (col.gameObject, 0.5f);
		}
	}
}
