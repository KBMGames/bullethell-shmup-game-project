using UnityEngine;
using System.Collections;

public class DestroyEnemyBullets : MonoBehaviour {
	
	public GameObject Pickup;
	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "EnemyBullet") {

			Instantiate (Pickup,transform.position, transform.rotation);
			Destroy (col.gameObject);
		}
	}
}

