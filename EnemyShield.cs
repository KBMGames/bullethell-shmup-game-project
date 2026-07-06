using UnityEngine;
using System.Collections;

public class EnemyShield : MonoBehaviour {
	private bool light = false;

	void OnTriggerEnter(Collider col) 

	{

		if (col.gameObject.tag == "Bullet2")
		{
			light = !light;

		}
		if (col.gameObject.tag == "Bullet3")
		{
			light = !light;

		}



		if (light) 
		{
			GetComponent<MeshRenderer> ().enabled = true;
		}



		if (!light) 
		{
			GetComponent<MeshRenderer> ().enabled = false;
		}

	}

}
