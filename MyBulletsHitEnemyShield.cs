using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class MyBulletsHitEnemy : MonoBehaviour
{
	void OnTriggerEnter(Collider col)

	{if (col.gameObject.tag == "Bullet1") {

			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
		}


	}

	void OnTriggerEnter2(Collider col)

	{if (col.gameObject.tag == "Bullet2") {

			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
		}


	}
}