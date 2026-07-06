using UnityEngine;
using System.Collections;

public class MyShield : MonoBehaviour {
	private bool light = false;

		void OnTriggerEnter(Collider col) 

		{
			
			if (col.gameObject.tag == "EnemyBullet")
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
