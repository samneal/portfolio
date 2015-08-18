using UnityEngine;
using System.Collections;

public class spawnBlue : MonoBehaviour {

	public static spawnBlue Instance;
	public GameObject blueX;
	public GameObject blueY;
	public GameObject blueB;

	public float minionCost = 5f;
	public float blueMinHealth = 5f;
	public float blueMinAttack = 5f;
	// public Transform blueMinion;
	public float blueSpeed = 20f;
	public float blueYSpeed = 20f;
	private float numClicks = 0f;

	public bool xIsReady = true;
	public bool yIsReady = true;
	public bool bIsReady = true;
//	bool BoneSawIsReady = always_true;

	public float coolDown = 1f;
	
	bool showText = false;


	// Use this for initialization
	void Start () {
		Instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		if (blueShop.showShop) {

		} else {
			if (xIsReady) {
				if (Input.GetButtonDown ("xButton") || Input.GetKeyDown ("q")) {
					if (blueGold.Instance.gold >= minionCost) {
						Instantiate (blueX, new Vector3 (-66f, 0.1f, -180f), Quaternion.identity);
						numClicks++;
						blueGold.Instance.gold = blueGold.Instance.gold - minionCost;
						xIsReady = false;
						Invoke ("cooldownTimerX", coolDown);



					}
				}
			}
			if (yIsReady) {
				if (Input.GetButtonDown ("yButton") || Input.GetKeyDown ("w")) {
					if (blueGold.Instance.gold >= minionCost) {
					Instantiate (blueY, new Vector3 (42f, 0.1f, -180f), Quaternion.identity);
						numClicks++;
						blueGold.Instance.gold = blueGold.Instance.gold - minionCost;;
						yIsReady = false;
						Invoke ("cooldownTimerY", coolDown);

					}
				}
			}
			if (bIsReady) {
				if (Input.GetButtonDown ("bButton") || Input.GetKeyDown ("e")) {
					if (blueGold.Instance.gold >= minionCost) {
						Instantiate (blueB, new Vector3 (145f, 0.1f, -180f), Quaternion.identity);
						numClicks++;
						blueGold.Instance.gold = blueGold.Instance.gold - minionCost;
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
