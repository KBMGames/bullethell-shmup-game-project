using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class EnemyBulletHitsMyShield : MonoBehaviour
{
	void OnTriggerEnter(Collider col)

	{if (col.gameObject.tag == "EnemyBullet") {
			
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
		}


	}
}