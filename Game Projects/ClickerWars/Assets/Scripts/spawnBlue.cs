using UnityEngine;
using System.Collections;

public class spawnBlue : MonoBehaviour {
	public GameObject blueX;
	public GameObject blueY;
	public GameObject blueB;

	public static float minionCost = 5f;
	public static float blueMinHealth = 5f;
	public static float blueMinAttack = 5f;
	// public Transform blueMinion;
	public static float blueSpeed = 20f;
	public static float blueYSpeed = 20f;
	private float numClicks = 0f;

	public static bool xIsReady = true;
	public static bool yIsReady = true;
	public static bool bIsReady = true;
//	bool BoneSawIsReady = always_true;

	public static float coolDown = 1f;
	
	bool showText = false;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (blueShop.showShop) {

		} else {
			if (xIsReady) {
				if (Input.GetButtonDown ("xButton") || Input.GetKeyDown ("q")) {
					if (blueGold.gold >= minionCost) {
						Instantiate (blueX, new Vector3 (-66f, 0.1f, -180f), Quaternion.identity);
						numClicks++;
						blueGold.gold = blueGold.gold - minionCost;
						xIsReady = false;
						Invoke ("cooldownTimerX", coolDown);



					}
				}
			}
			if (yIsReady) {
				if (Input.GetButtonDown ("yButton") || Input.GetKeyDown ("w")) {
					if (blueGold.gold >= minionCost) {
					Instantiate (blueY, new Vector3 (42f, 0.1f, -180f), Quaternion.identity);
						numClicks++;
						blueGold.gold = blueGold.gold - minionCost;
						yIsReady = false;
						Invoke ("cooldownTimerY", coolDown);

					}
				}
			}
			if (bIsReady) {
				if (Input.GetButtonDown ("bButton") || Input.GetKeyDown ("e")) {
					if (blueGold.gold >= minionCost) {
						Instantiate (blueB, new Vector3 (145f, 0.1f, -180f), Quaternion.identity);
						numClicks++;
						blueGold.gold = blueGold.gold - minionCost;
						bIsReady = false;
						Invoke ("cooldownTimerB", coolDown);
					}
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
