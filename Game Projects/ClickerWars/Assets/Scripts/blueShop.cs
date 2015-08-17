using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class blueShop : MonoBehaviour {

	public Material activeShop1;
	public Material activeShop2;
	public Material cooldownMat;

	public Text[] itemText;
	public float[] itemCost = {100f, 100f, 100f, 100f, 100f};
	string[] itemDescrip = {"Increase Attack","junk","Increase Health","junk","+ Spawn Rate","junk", "Spawn Superminion","junk","+Gold Per Second","junk","Close Menu"};

	bool showShop;
	public GameObject shop;
	// Use this for initialization
	void Start () {
		itemText = gameObject.GetComponentsInChildren<Text>();
		showShop = false;
		shop.SetActive (showShop);
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetButtonDown ("aButton")){
			showShop = !showShop;
			shop.SetActive(showShop);

		}


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


			if(blueGold.gold >= itemCost[0]){
			if(showShop){
			//	gameObject.GetComponent<Renderer>().material = activeShop1;
				if (Input.GetButtonDown ("xButton") || Input.GetKeyDown ("q")) {
				blueGold.gold = blueGold.gold - itemCost[0];
				spawnBlue.blueMinAttack++;
				}
			}
			}
						

	
		if(blueGold.gold >= itemCost[1]){
		//	gameObject.GetComponent<Renderer>().material = activeShop2;
			if(showShop){
				if (Input.GetButtonDown ("yButton") || Input.GetKeyDown ("w")) {
			
		
						blueGold.gold = blueGold.gold - itemCost[0];
						spawnBlue.blueMinHealth++;
			}
			}
			
		}
	





	}
}
