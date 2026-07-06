using UnityEngine;
using System.Collections;

public class DestroyMyBullet2 : MonoBehaviour {

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "Bullet2") {
			Destroy (col.gameObject);
		}
	}
}