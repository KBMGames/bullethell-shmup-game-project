using UnityEngine;
using System.Collections;

public class DestroyMyBullet3 : MonoBehaviour {

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "Bullet3") {
			Destroy (col.gameObject);
		}
	}
}