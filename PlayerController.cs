using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
	private Rigidbody myRigidbody;

	private Vector3 moveInput;
	private Vector3 moveVelocity;

	private Camera mainCamera;

	public GunController theGun;
	public GunController theGun2;
	public GunController theGun3;

	public bool useController;

	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody> ();
		mainCamera = FindObjectOfType<Camera> ();

		
	}
	
	// Update is called once per frame
	void Update () {
		moveInput = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0f, Input.GetAxisRaw ("Vertical"));
		moveVelocity = moveInput * moveSpeed;

		if (!useController) {

			// rotate with mouse
			Ray cameraRay = mainCamera.ScreenPointToRay (Input.mousePosition);
			Plane groundPlane = new Plane (Vector3.up, Vector3.zero);
			float rayLenght;

			if (groundPlane.Raycast (cameraRay, out rayLenght)) {

				Vector3 pointToLook = cameraRay.GetPoint (rayLenght);
				Debug.DrawLine (cameraRay.origin, pointToLook, Color.blue);

				transform.LookAt (new Vector3 (pointToLook.x, transform.position.y, pointToLook.z));
					
			}

			if (Input.GetMouseButtonDown (0))
				theGun.isFiring = true;

			if (Input.GetMouseButtonUp (0))
				theGun.isFiring = false;
			
			if (Input.GetMouseButtonDown (1))
				theGun2.isFiring = true;

			if (Input.GetMouseButtonUp (1))
				theGun2.isFiring = false;
			
			if (Input.GetMouseButtonDown (0))
				theGun3.isFiring = true;

			if (Input.GetMouseButtonUp (0))
				theGun3.isFiring = false;
		}

		// rotate with joystick controller
		if (useController) {

			Vector3 playerDirection = Vector3.right * Input.GetAxisRaw ("RHorizontal") + Vector3.forward * -Input.GetAxisRaw ("RVertical");
			if (playerDirection.sqrMagnitude > 0.0f) {
				transform.rotation = Quaternion.LookRotation (playerDirection, Vector3.up);
			}

			if (Input.GetKeyDown (KeyCode.Joystick1Button5)) 
				theGun.isFiring = true;
			
			if (Input.GetKeyUp (KeyCode.Joystick1Button5)) 
				theGun.isFiring = false;
			


			if (Input.GetKeyDown (KeyCode.Joystick1Button4)) 
					theGun2.isFiring = true;

			if (Input.GetKeyUp (KeyCode.Joystick1Button4)) 
					theGun2.isFiring = false;
			


			if (Input.GetKeyDown (KeyCode.Joystick1Button4)) 
				theGun3.isFiring = true;

			if (Input.GetKeyUp (KeyCode.Joystick1Button4)) 
				theGun3.isFiring = false;
				
			}
		}


	void FixedUpdate(){
		myRigidbody.velocity = moveVelocity;

	}
}
