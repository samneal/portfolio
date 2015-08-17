using UnityEngine;
using System.Collections;

public class SpawnFood : MonoBehaviour {

	public GameObject foodPrefab;    //Adding a public GameObject object
	public AudioSource foodSpawnSound;
	public Transform borderTop;
	public Transform borderBottom;
	public Transform borderLeft;
	public Transform borderRight;

	void Spawn() {

			//X and Y are int to insure it spawns at whole point and not partial point
			// Positions between left and right border
			int x = (int)Random.Range (borderLeft.position.x,
		                           borderRight.position.x);
			// Spawns object randomly between top and bottom border
			int y = (int)Random.Range (borderBottom.position.y,
		                          borderTop.position.y);
			// Instantiates the food at (x,y)
			Instantiate (foodPrefab,
		            new Vector2 (x, y),
		            Quaternion.identity); //default rotation
			foodSpawnSound.Play ();


		Destroy(GameObject.Find("FoodPrefab(Clone)"), 12);


	}
	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", 3, 6);  //Starting in 3 seconds, repeats every 4 seconds
	}
	
	/*// Update is called once per frame
	void Update () {
	
	}
	*/
}
