using UnityEngine; using System.Collections;

public class OnDeathInitiate : MonoBehaviour {

	public float maxHealth = 100;

	public float currHealth = 100;

	public float healthBarLength;

	void Start () {
		healthBarLength = Screen.width / 2;
	}


	void Update () {
		AddjustCurrentHealth(0);
		Death ();
		if (GameObject.FindWithTag ("Player") == null)
		{
			
			Application.LoadLevel(Application.loadedLevel);
		}
	}


	void OnGUI(){
		GUI.Box(new Rect(10, 10, healthBarLength, 20), currHealth + "/" + maxHealth);    
	}


	public void AddjustCurrentHealth(int adj) {
		currHealth += adj;    

		if (currHealth < 0)
			currHealth = 0;

		if (currHealth > maxHealth)
			currHealth = maxHealth;

		if (maxHealth < 1)
			maxHealth = 1;

		healthBarLength = (Screen.width / 2) * (currHealth / (float)maxHealth);
	}
	public void Death() {
		if (currHealth == 0) {
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}