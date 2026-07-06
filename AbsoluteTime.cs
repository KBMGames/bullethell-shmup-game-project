using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbsoluteTime : MonoBehaviour {

	[Range(0,2)]
	public float TimeScale = 1.0f;
	

	void Update () {
		Time.timeScale = TimeScale;
	}
}
