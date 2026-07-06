using UnityEngine; 
using System.Collections;
using System.Collections.Generic;

public class ShowDeathMenu : MonoBehaviour {
	


	void Update()

	{

		if (GameObject.Find ("Player")) 
		{

		
			GetComponent<Canvas> ().enabled = false;

		}

		if (GameObject.Find ("Player") == null) 
		{
			
			GetComponent<Canvas> ().enabled = true;

		}

	}


}


