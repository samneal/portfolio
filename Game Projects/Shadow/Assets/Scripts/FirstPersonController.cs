using UnityEngine;
using System.Collections;

[RequireComponent (typeof(CharacterController))]
public class FirstPersonController : MonoBehaviour {

	public float thrust;
	public float movementSpeed = 5.0f;
	public float mouseSensitivity = 5.0f;
	public float jumpSpeed = 20;  //Jump height

	public GameObject flareGrenade;


	public static float verticalRotation = 0;
	public float upDownRange = 60.0f;

	float verticalVelocity = 0;

	CharacterController cc;
	private bool cursorShouldBeLocked = true;

	// Use this for initialization
	void Start () {

		// Screen.lockCursor = true;        --This hides the mouse, but doesn't really work in the editor. Unlock for out of Unity testing
		cc = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Escape)){
			cursorShouldBeLocked = !cursorShouldBeLocked;
		}

		if (cursorShouldBeLocked)
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
		}
		else
		{
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
		}

	

		//Rotation

		float rotLeftRight = Input.GetAxis ("Mouse X") * mouseSensitivity;
		transform.Rotate (0, rotLeftRight, 0);

		verticalRotation -= Input.GetAxis ("Mouse Y") * mouseSensitivity;
		verticalRotation = Mathf.Clamp (verticalRotation, -upDownRange, upDownRange);
		Camera.main.transform.localRotation = Quaternion.Euler (verticalRotation, 0, 0);

		//Movement



		float forwardSpeed = Input.GetAxis ("Vertical") * movementSpeed;  //This is our movement speed variable
		float sideSpeed = Input.GetAxis ("Horizontal") * movementSpeed;
		
		Vector3 speed = new Vector3 (sideSpeed, verticalVelocity, forwardSpeed);  //y component does gravity  -Physics.gravity is a vector, so only want y component



		/*
		if (cc.isGrounded && Input.GetButtonDown ("Jump") ){
		
		verticalVelocity = jumpSpeed;
		
		}
		*/
		verticalVelocity += Physics.gravity.y * Time.deltaTime; //adds the gravity by part of gravity every second, downward gravity

		if (Input.GetButtonDown ("Jump") && cc.isGrounded){
			
			verticalVelocity = jumpSpeed;
			
		}




		speed = transform.rotation * speed;   //transform.rotation gets current rotation angle
		// speed.y -= Physics.gravity.y * Time.deltaTime;


		cc.Move (speed * Time.deltaTime);   // cc.Move expects how many unit distances of movement does it move each frame, Time.deltaTime keeps movement speed constant. Also .move has no gravity
	
	}
}
