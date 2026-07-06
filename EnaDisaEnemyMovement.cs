using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnaDisaEnemyMovement : MonoBehaviour {

	void OnTriggerExit (Collider col)
	{
		if (col.gameObject.tag == "EnemyMoveDisable")
		{
			GetComponent<EnemyController> ().enabled = false;
			GetComponent<EnemyControllerFaster> ().enabled = true;
		}
	}
	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "EnemyMoveDisable")
		{
			GetComponent<EnemyController> ().enabled = true;
			GetComponent<EnemyControllerFaster> ().enabled = false;
		}
	}
}

