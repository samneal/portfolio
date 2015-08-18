using UnityEngine;
using System.Collections;

public class spawnRed : MonoBehaviour {

	public static spawnRed Instance;
	public GameObject redX;
	public GameObject redY;
	public GameObject redB;

	public float minionCost = 5f;
	public float redMinHealth = 5f;
	public float redMinAttack = 5f;
	// public Transform redMinion;
	public float redSpeed = 20f;
	public float redYSpeed = 20f;

	public float coolDown = 1f;

	private float numClicks = 0f;

	public bool xIsReady = true;
	public bool yIsReady = true;
	public bool bIsReady = true;
	//	bool BoneSawIsReady = always_true;

	bool showText = false;

	// Use this for initialization
	void Start () {
		Instance = this;

	}
	
	// Update is called once per frame
	void Update () {
		if (redShop.showShop) {
			
		} else {
			if (xIsReady) {
				if (Input.GetButtonDown ("p2xButton") || Input.GetKeyDown ("i")) {

					if (redGold.Instance.gold >= minionCost) {
						Instantiate (redX, new Vector3 (-70f, 0.1f, 180f), Quaternion.identity);
						numClicks++;
						redGold.Instance.gold = redGold.Instance.gold - minionCost;
						xIsReady = false;
						Invoke ("cooldownTimerX", coolDown);
					}

				}
			}
			if (yIsReady) {
				if (Input.GetButtonDown ("p2yButton") || Input.GetKeyDown ("o")) {
					if (redGold.Instance.gold >= minionCost) {
						Instantiate (redY, new Vector3 (42f, .1f, 180f), Quaternion.identity);
						numClicks++;
						redGold.Instance.gold = redGold.Instance.gold - minionCost;
						yIsReady = false;
						Invoke ("cooldownTimerY", coolDown);
					}
				}
			}
			if (bIsReady) {
				if (Input.GetButtonDown ("p2bButton") || Input.GetKeyDown ("p")) {
					if (redGold.Instance.gold >= minionCost) {
						Instantiate (redB, new Vector3 (145f, 0.1f, 180f), Quaternion.identity);
						numClicks++;
						redGold.Instance.gold = redGold.Instance.gold - minionCost;
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
