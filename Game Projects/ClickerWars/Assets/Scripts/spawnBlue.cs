using UnityEngine;
using System.Collections;

public class spawnBlue : MonoBehaviour {
	public Transform blueX;
	public Transform blueY;
	public Transform blueB;

	public static float blueMinHealth = 1f;
	public static float blueMinAttack = 1f;
	// public Transform blueMinion;
	public static float blueSpeed = 20f;
	public static float blueYSpeed = 20f;
	private float numClicks = 0f;

	public static bool xIsReady = true;
	public static bool yIsReady = true;
	public static bool bIsReady = true;
//	bool BoneSawIsReady = always_true;

	public static float coolDown = 1.0f;
	
	bool showText = false;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (xIsReady) {
			if (Input.GetButtonDown ("xButton") || Input.GetKeyDown ("q")) {

				Instantiate (blueX, new Vector3 (-35.8f, 0, -65.4f), Quaternion.identity);
				numClicks++;
				xIsReady = false;
				Invoke ("cooldownTimerX",coolDown);


			}
		}
		if (yIsReady) {
			if (Input.GetButtonDown ("yButton") || Input.GetKeyDown ("w")) {

				Instantiate (blueY, new Vector3 (0.9f, 0, -65.4f), Quaternion.identity);
				numClicks++;
				yIsReady = false;
				Invoke ("cooldownTimerY",coolDown);

			}
		}
		if (bIsReady) {
			if (Input.GetButtonDown ("bButton") || Input.GetKeyDown ("e")) {

				Instantiate (blueB, new Vector3 (34.2f, 0, -65.4f), Quaternion.identity);
				numClicks++;
				bIsReady = false;
				Invoke ("cooldownTimerB",coolDown);
			}
		}
	
	}

	
	void changeCheaterText(){
		showText = !showText;
	}

	void cooldownTimerX(){
		xIsReady = true;
	}
	void cooldownTimerY(){
		yIsReady = true;
	}
	void cooldownTimerB(){
		bIsReady = true;
	}

}
