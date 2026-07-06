using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCToggleCheat : MonoBehaviour {


	private bool Initiate = false;




	void Update(){

		if (Input.GetKeyDown (KeyCode.C))
		{
			Initiate = !Initiate;
		}



		if (Initiate) 
		{
			GetComponent<SphereCollider> ().enabled = true;
		}



		if (!Initiate) 
		{
			GetComponent<SphereCollider> ().enabled = false;
		}



	}


}
