using UnityEngine;
using System.Collections;

public class WorldBehavior : MonoBehaviour {

	public float moveSpeed = 10f;
	public float turnSpeed = 50f;
	static public int randomVal = 0;
	// Use this for initialization
	/* IEnumerator Wait(float duration)
	{
		for (float timer = 0; timer < duration; timer+= Time.deltaTime)
			yield return 0;

	}

	IEnumerator Rotate() {
		transform.Rotate(0, 0, 5 * Time.deltaTime);
		yield return StartCoroutine (Wait (1.0f));
		//transform.Rotate(0, 0, -5 * Time.deltaTime);
		yield return StartCoroutine (Wait (1.0f));
	}
	*/
	public int scoreCheck = 0;
	static public float rotSpeed = .025f;
	public float speedInc = .0008f;
	public bool clockWise = false;

	void Start () {

	}
	
	// Update is called once per frame             -------You should eventually put this into its own function so you can call it to gradually increase difficulty------------
	void Update () {

		int rando = Random.Range (1, 500);
		randomVal = rando;                    //Sets an equal random value for the rotation of the bounceys
		if (rando % 100 == 0) {
			clockWise = !clockWise;
		}
		
		
		if(!clockWise){
			transform.Rotate (0, 0, rotSpeed);
						
		}
		if(clockWise){
			transform.Rotate (0,0,-rotSpeed);
		}

		if (Snake.score > scoreCheck  && rotSpeed < 1.75f) {
			rotSpeed += speedInc;
			scoreCheck++;
		}


	}




}
