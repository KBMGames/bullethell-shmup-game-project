using UnityEngine;
using System.Collections;

public class EnableEnemyBulletsScript : MonoBehaviour {
	


	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "EnemyBulletEnabler")
		{
			GetComponent<GunController> ().enabled = true;
	
		}
	}
	void OnTriggerExit (Collider col)
	{
		if (col.gameObject.tag == "EnemyBulletEnabler")
		{
			GetComponent<GunController> ().enabled = false;
		
		}
	}

}
