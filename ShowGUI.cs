using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowGUI : MonoBehaviour {

	private bool Stop = false;
	private bool Pause = false;




	void Update()

	{



		if (Input.GetKeyDown (KeyCode.Escape )) 
			{
				Stop = !Stop;
			}
			

				if (Stop) 
				{
					Time.timeScale = 0;
				}


				if (!Stop) 
				{
					Time.timeScale = 1;
				}

			//----------------------------------------------------------------------------------------//

			if (Input.GetKeyDown (KeyCode.Escape))
			{
				Pause = !Pause;
			}



				if (Pause) 
				{
					GetComponent<Canvas> ().enabled = true;
				}



				if (!Pause) 
				{
					GetComponent<Canvas> ().enabled = false;
				}
				


		if (GameObject.Find ("Player") == null) 
		{

			Time.timeScale = 0;

		}
		if (GameObject.Find ("EnemyShipBoss") == null) 
		{
			
			Time.timeScale = 0;
		}


	}


}

