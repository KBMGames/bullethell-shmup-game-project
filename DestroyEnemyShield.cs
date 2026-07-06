using UnityEngine;
using System.Collections;

public class DestroyEnemyShield : MonoBehaviour {

	public GameObject deathFx;

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "EnemyShield") {

			Instantiate (deathFx, transform.position, transform.rotation);
			Destroy (col.gameObject, 0.5f);
		}
	}
}
