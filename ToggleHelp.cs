using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleHelp : MonoBehaviour {



	private bool Pause = false;
	private bool Stop = false;



	void Update(){

		if (Input.GetKeyDown (KeyCode.H))
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



	}
}
