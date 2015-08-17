using UnityEngine;
using System.Collections;

public class spawnBouncey : MonoBehaviour {
	public GameObject bounceyPrefab;
	public AudioSource bounceySpawnSFX;
	int numBounceys = 0;
	public int scoreChecker = 4;   //This number is how many foods it takes before the world starts spawning bounceys
	public Transform borderTop;
	public Transform borderBottom;
	public Transform borderLeft;
	public Transform borderRight;

	public bool isSpawn = false;
	// Use this for initialization
	void Start () {
	//	InvokeRepeating ("Spawn", 1, 15);  //Starting in X seconds, repeats every Y seconds
	}

	// Update is called once per frame
	void Update () {
		if (Snake.score > scoreChecker) {

			if (numBounceys <= 5) {

				Invoke ("spawnNewBouncey", 6f);

			}
			if(isSpawn){
				Invoke ("destroyBouncey", 12f);
				isSpawn = false;
			}
			scoreChecker += 2;
		}
			
				
	}


	void Spawn() {

	}
	void destroyBouncey(){
		Destroy(GameObject.Find("bounceyPrefab(Clone)"), 20);
	}
	void spawnNewBouncey(){
		//X and Y are int to insure it spawns at whole point and not partial point
		// Positions between left and right border
		int x = (int)Random.Range (borderLeft.position.x,
		                           borderRight.position.x);
		// Spawns object randomly between top and bottom border
		int y = (int)Random.Range (borderBottom.position.y,
		                           borderTop.position.y);
		// Instantiates the food at (x,y)
		Instantiate (bounceyPrefab,
		             new Vector2 (x, y),
		             Quaternion.identity); //default rotation
		isSpawn = true;
		bounceySpawnSFX.Play ();
		
		
		numBounceys++;
	}


}
