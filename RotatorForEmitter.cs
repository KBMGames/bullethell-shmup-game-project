using UnityEngine;

public class RotatorForEmitter : MonoBehaviour
{
	void Update()
	{
		


		//y axis rotation
		transform.Rotate(Vector3.up * Time.deltaTime * 40, Space.World);
	}
}