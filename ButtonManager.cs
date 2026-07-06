using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{ 


	public void NewGameBtn(string newGameLevel)
	{
	
		SceneManager.LoadScene ("MainGame0");
	
	}
	public void NextGameBtn(string newGameLevel)
	{
	
		SceneManager.LoadScene (newGameLevel);
	
	}
	public void ExitGameBtn(){
		
		Application.Quit ();
	
	}
	public void RestartBtn(){

		Application.LoadLevel (Application.loadedLevel);

	}
		


	
}

