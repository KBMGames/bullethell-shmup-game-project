using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnDeathInitiateNoGUI : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		
		if (GameObject.FindWithTag ("Player") == null)
		{

			SceneManager.LoadScene ("MainGame");
		}
	}
}
