using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCToggleGUI : MonoBehaviour {

	private bool Initiate = false;




	void Update(){

		if (Input.GetKeyDown (KeyCode.C))
		{
			Initiate = !Initiate;
		}

	

		if (Initiate) 
		{
			GetComponent<Canvas> ().enabled = true;
		}



		if (!Initiate) 
		{
			GetComponent<Canvas> ().enabled = false;
		}

	}
}
