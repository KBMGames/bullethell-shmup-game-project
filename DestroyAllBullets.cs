using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAllBullets : MonoBehaviour {

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "AbsoluteBulletDestroyer") {

			Destroy (this.gameObject);
		}
	}
}
