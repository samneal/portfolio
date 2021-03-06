﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class blueShop : MonoBehaviour {

	public Material activeShop1;
	public Material activeShop2;
	public Material cooldownMat;

	public Text[] itemText;
	public float[] itemCost = {100f, 100f, 500f, 500f, 100f};
	string[] itemDescrip = {"Increase Attack","junk","Increase Health","junk","-Minion Cost","junk", "(Waste Money)","junk","+Gold Per Second","junk","Close Menu"};
	private int iconSet = 1; //1-controller, 2-Keyboard
	public static bool showShop;
	public GameObject shop;
	public GameObject shopKey;
	public GameObject shopBut;


	// Use this for initialization
	void Start () {
		itemText = gameObject.GetComponentsInChildren<Text>();
		showShop = false;
		shop.SetActive (showShop);
		shopKey.SetActive (showShop);
		shopBut.SetActive (showShop);

		//Invoke ("checkControlType", 3f);
	}
	
	// Update is called once per frame
	void Update () {
		if (worldRules.p1ControlType == 1) {
			shop = shopBut;
		} else if(worldRules.p1ControlType == 2) {
			shop = shopKey;
		}

		if(Input.GetButtonDown ("aButton") || Input.GetKeyDown ("d")){
			showShop = !showShop;
			shop.SetActive(showShop);

		}

		//At some point go back and put all of this stuff into a loop
		int y = 0;
		itemText [0].text = itemDescrip[0];
		itemText [1].text = itemCost[0].ToString();
		itemText [2].text = itemDescrip[2];
		itemText [3].text = itemCost[1].ToString();
		itemText [4].text = itemDescrip[4];
		itemText [5].text = itemCost[2].ToString();
		itemText [6].text = itemDescrip[6];
		itemText [7].text = itemCost[3].ToString();
		itemText [8].text = itemDescrip[8];
		itemText [9].text = itemCost[4].ToString();
		itemText [10].text = itemDescrip[10];

		itemText [11].text = itemDescrip[0];
		itemText [12].text = itemCost[0].ToString();
		itemText [13].text = itemDescrip[2];
		itemText [14].text = itemCost[1].ToString();
		itemText [15].text = itemDescrip[4];
		itemText [16].text = itemCost[2].ToString();
		itemText [17].text = itemDescrip[6];
		itemText [18].text = itemCost[3].ToString();
		itemText [19].text = itemDescrip[8];
		itemText [20].text = itemCost[4].ToString();
		itemText [21].text = itemDescrip[10];


			if(blueGold.Instance.gold >= itemCost[0]){
			if(showShop){
			//	gameObject.GetComponent<Renderer>().material = activeShop1;
				if (Input.GetButtonDown ("xButton") || Input.GetKeyDown ("q")) {
				blueGold.Instance.gold = blueGold.Instance.gold - itemCost[0];
				spawnBlue.Instance.blueMinAttack++;
					itemCost[0] = itemCost[0] + 100f;
				}
			}
			}
						

	
		if(blueGold.Instance.gold >= itemCost[1]){
		//	gameObject.GetComponent<Renderer>().material = activeShop2;
			if(showShop){
				if (Input.GetButtonDown ("yButton") || Input.GetKeyDown ("w")) {
			
		
						blueGold.Instance.gold = blueGold.Instance.gold - itemCost[0];
						spawnBlue.Instance.blueMinHealth++;
					itemCost[1] = itemCost[1] + 100f;
			}
			}
			
		}

		if(blueGold.Instance.gold >= itemCost[2]){
			//	gameObject.GetComponent<Renderer>().material = activeShop2;
			if(showShop){
				if (Input.GetButtonDown ("bButton") || Input.GetKeyDown ("e")) {
					if(spawnBlue.Instance.minionCost >=1){
						
						blueGold.Instance.gold = blueGold.Instance.gold - itemCost[2];
						spawnBlue.Instance.minionCost--;
						itemCost[2] = itemCost[2] + 500f;
					}else{
						//Blur out shop item
					}
				}
			}
			
		}

		if(blueGold.Instance.gold >= itemCost[3]){
			//	gameObject.GetComponent<Renderer>().material = activeShop2;
			if(showShop){
				if (Input.GetButtonDown ("lbButton") || Input.GetKeyDown ("a")) {
					if(spawnBlue.Instance.minionCost >=1){
					
					blueGold.Instance.gold = blueGold.Instance.gold - itemCost[2];
					spawnBlue.Instance.minionCost--;
					itemCost[3] = itemCost[3] + 500f;
					}else{
						//Blur out shop item
					}
				}
			}
			
		}
		if(blueGold.Instance.gold >= itemCost[4]){
			//	gameObject.GetComponent<Renderer>().material = activeShop2;
			if(showShop){
				if (Input.GetButtonDown ("rbButton") || Input.GetKeyDown ("s")) {
					if(spawnBlue.Instance.minionCost >=1){
						
						blueGold.Instance.goldRate -= .05f;
						spawnBlue.Instance.minionCost--;
						itemCost[4] = itemCost[4] + 100f;
					}else{
						//Blur out shop item
					}
				}
			}
			
		}

	}


}
