using UnityEngine;
using System.Collections;

public class spawnRed : MonoBehaviour {
	public Transform redX;
	public Transform redY;
	public Transform redB;

	public static float redMinHealth = 1f;
	public static float redMinAttack = 1f;
	// public Transform redMinion;
	public static float redSpeed = 20f;
	public static float redYSpeed = 20f;

	public static float coolDown = 1.0f;

	private float numClicks = 0f;

	public static bool xIsReady = true;
	public static bool yIsReady = true;
	public static bool bIsReady = true;
	//	bool BoneSawIsReady = always_true;

	bool showText = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (xIsReady) {
			if (Input.GetButtonDown ("p2xButton") || Input.GetKeyDown ("i")) {
				Instantiate (redX, new Vector3 (36f, 0, 65.4f), Quaternion.identity);
				numClicks++;
				xIsReady = false;
				Invoke ("cooldownTimerX",coolDown);

			}
		}
		if (yIsReady) {
			if (Input.GetButtonDown ("p2yButton") || Input.GetKeyDown ("o")) {
				Instantiate (redY, new Vector3 (0f, 0, 65.4f), Quaternion.identity);
				numClicks++;
				yIsReady = false;
				Invoke ("cooldownTimerY",coolDown);
			}
		}
		if (bIsReady) {
			if (Input.GetButtonDown ("p2bButton") || Input.GetKeyDown ("p")) {
				Instantiate (redB, new Vector3 (-36f, 0, 65.4f), Quaternion.identity);
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
