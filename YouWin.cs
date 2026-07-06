using UnityEngine; 
using System.Collections;
using System.Collections.Generic;

public class YouWin : MonoBehaviour {



	void Update()

	{

		if (GameObject.Find ("EnemyShipBoss")) 
		{

			GetComponent<Canvas> ().enabled = false;
			Time.timeScale = 1;
		}

		if (GameObject.Find ("EnemyShipBoss") == null) 
		{

			GetComponent<Canvas> ().enabled = true;
			Time.timeScale = 0;
		}

	}


}
