using UnityEngine;
using System.Collections;
using System.Collections.Generic;   //These two libs allow us to make lists
using System.Linq;


public class Snake : MonoBehaviour {
	public int hitCounter = 0;
	static public int score = 0;
	public float newMoveSpeed = .125f;

	public AudioSource foodSound;
	public AudioSource wallBump;

	void OnGUI()
	{

	//	GUI.skin.label.fontSize = 30;
	//	GUI.Label(new Rect(Screen.width/2,Screen.height/2, 100, 200), ""+score);

	}
	// Current Movement Direction
	// (by default it moves to the right)
	Vector2 dir = Vector2.right;

	//This is a list object to keep track of the tail.
	List<Transform> tail = new List<Transform>();

	//Did the snake eat something?
	bool ate = false;

	//Tail prefab
	public GameObject tailPrefab; //From what I can tell, Public GameObject is used to create functions and stuff for things created in visual editor

	
	// Use this for initialization
	void Start () {
		// Move the Snake every 300ms
		score = 0;
		Invoke("Move", 0.1f);    
	}
	
	// Update is called once per frame
	//Use the update function to check for keypresses because it will check in real time

	void Update() {


			

		if (dir == Vector2.right) {
			if (Input.GetMouseButtonDown (0)) {
				Touch touch = Input.GetTouch (0);
				if (touch.position.x < Screen.width / 2) {
					dir = Vector2.up;
				} else if (touch.position.x > Screen.width / 2) {
					dir = -Vector2.up;
				}
			}
									
		} else if (dir == -Vector2.up) {
			if (Input.GetMouseButtonDown (0)) {
				Touch touch = Input.GetTouch (0);
				if (touch.position.x < Screen.width / 2) {
					dir = Vector2.right;
				} else if (touch.position.x > Screen.width / 2) {
					dir = -Vector2.right;
				}
				}
			} else if (dir == -Vector2.right) {
				if (Input.GetMouseButtonDown (0)) {	
					Touch touch = Input.GetTouch (0);
					if (touch.position.x < Screen.width / 2) {
						dir = -Vector2.up;
					} else if (touch.position.x > Screen.width / 2) {
						dir = Vector2.up;
					}
				}		

			} else if (dir == Vector2.up) {
				if (Input.GetMouseButtonDown (0)) {
					Touch touch = Input.GetTouch (0);
					if (touch.position.x < Screen.width / 2) {
						dir = -Vector2.right;
					} else if (touch.position.x > Screen.width / 2) {
						dir = Vector2.right;
					}
			
				}
				
			}


			// Move in a new Direction?
			if (dir == Vector2.right) {
				if (Input.GetKeyDown (KeyCode.RightArrow)) {
					dir = -Vector2.up;
				}
				if (Input.GetKeyDown (KeyCode.LeftArrow)) {
					dir = Vector2.up;
				}
			} else if (dir == -Vector2.up) {
				if (Input.GetKeyDown (KeyCode.RightArrow)) {
					dir = -Vector2.right;
				}
				if (Input.GetKeyDown (KeyCode.LeftArrow)) {
					dir = Vector2.right;
				}
			} else if (dir == -Vector2.right) {
				if (Input.GetKeyDown (KeyCode.RightArrow)) {
					dir = Vector2.up;
				}
				if (Input.GetKeyDown (KeyCode.LeftArrow)) {
					dir = -Vector2.up;
				}
			} else if (dir == Vector2.up) {
				if (Input.GetKeyDown (KeyCode.RightArrow)) {
					dir = Vector2.right;
				}
				if (Input.GetKeyDown (KeyCode.LeftArrow)) {
					dir = -Vector2.right;
				}
			}
			// '-up' means 'down'
			/*
		else if (Input.GetKey(KeyCode.LeftArrow))
			dir = -Vector2.right; // '-right' means 'left'
		else if (Input.GetKey(KeyCode.UpArrow))
			dir = Vector2.up;
			*/


		}


	//Created the move function to move forward every 300ms. DOES NOT REGISTER KEYPRESSES (update does that)
	void Move() {
		//This saves the current position and creates the gap
		Vector2 v = transform.position;

		// Move head into new direction (this creates a gap)
		transform.Translate(dir);

//Other general notes-- Translate means "Add this vector to my position". Then we check for tail position, then
//then change last elements position to gap position (where head used to be). Also have to keep our list order hence InsertAt and Remove

		//Ate something? Then insert a new element into the gap
		if (ate) {  //checks if ate is true
			foodSound.Play ();
			score++;
			if (newMoveSpeed > 0.085f) {
			newMoveSpeed -= 0.005f;
			}

		/*	//Load prefab object into the world
			GameObject g = (GameObject)Instantiate (tailPrefab,
			                                       v,                   //Instantiates at position v
			                                       Quaternion.identity);   //Quaternion.identity is default rotation
			//Or rather how, I know it loads the TailPrefab object
			//Keep track of the trailprefab in our tail list
			tail.Insert (0, g.transform);

			//Reset the ate flag to false
			*/
			ate = false;

		}
		//Do we have a tail?



		Invoke ("Move", newMoveSpeed);  
		

	}
//Note- We use coll.name.StartsWith because food is technically called FoodPrefab(Clone) after it's instantiated
//Using a tag would be more elegant, but we are checking strings now to see if they match
	void OnTriggerEnter2D(Collider2D coll) {
		//Food?
		if (coll.name.StartsWith ("FoodPrefab")) {
			//Get longer in next Move call
			ate = true;

			//remove the food
			Destroy (coll.gameObject);
		}
		//Collided with Tail or Border
		else if (coll.name.StartsWith ("Border") || coll.name.StartsWith ("bouncey")) {
			hitCounter++;
			dir = -dir;
			wallBump.Play ();

			// foodSound.Play ();

			// StartCoroutine(MyCoroutine());    //Pause for one frame

			// dir = .5f*dir;
			if(hitCounter >= 2){
				//ToDo 'You Lose'' screen
				Application.LoadLevel ("gameOver");
			}
		}else{
			hitCounter++;
			if(hitCounter >= 2){
			//ToDo 'You Lose'' screen
			Application.LoadLevel ("gameOver");
			}
		}

	}




}
