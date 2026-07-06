using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightClickSlowMo : MonoBehaviour {

public TimeManager  timeManager;

	void Update ()
	{
		if (Input.GetMouseButtonDown(1))
		timeManager.DoSlowMotion();
	}








}
