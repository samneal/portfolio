using UnityEngine;
using System.Collections;

public class spawnRed : MonoBehaviour {
	public GameObject redX;
	public GameObject redY;
	public GameObject redB;

	public static float minionCost = 5f;
	public static float redMinHealth = 5f;
	public static float redMinAttack = 5f;
	// public Transform redMinion;
	public static float redSpeed = 20f;
	public static float redYSpeed = 20f;

	public static float coolDown = 1f;

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

				if(redGold.gold >= minionCost){
				Instantiate (redX, new Vector3 (-70f, 0.1f, 180f), Quaternion.identity);
				numClicks++;
				redGold.gold = redGold.gold - minionCost;
				xIsReady = false;
				Invoke ("cooldownTimerX",coolDown);
				}

			}
		}
		if (yIsReady) {
			if (Input.GetButtonDown ("p2yButton") || Input.GetKeyDown ("o")) {
				if(redGold.gold >= minionCost){
				Instantiate (redY, new Vector3 (42f, .1f, 180f), Quaternion.identity);
				numClicks++;
				redGold.gold = redGold.gold - minionCost;
				yIsReady = false;
				Invoke ("cooldownTimerY",coolDown);
			}
			}
		}
		if (bIsReady) {
			if (Input.GetButtonDown ("p2bButton") || Input.GetKeyDown ("p")) {
				if(redGold.gold >= minionCost){
				Instantiate (redB, new Vector3 (145f, 0.1f, 180f), Quaternion.identity);
				numClicks++;
				redGold.gold = redGold.gold - minionCost;
				bIsReady = false;
				Invoke ("cooldownTimerB",coolDown);

			}
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
