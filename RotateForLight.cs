using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateForLight : MonoBehaviour {



	void Update () 
	{
		transform.Rotate (new Vector3 (10, 2, 0) * Time.deltaTime / 25);		
	}
}


