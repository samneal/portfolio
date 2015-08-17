using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class redGold : MonoBehaviour {

	public float gold = 0f;
	public float goldPerSecond = 1.0f;
	public float goldMultiplyer = 1.0f;
	public float minionBaseVal = 0f; 
	public static float minionsKilled = 0f;
	public static float goldRate = 0.5f;
	
	public Text[] goldText;
	// Use this for initialization
	void Start () {
		goldText = gameObject.GetComponentsInChildren<Text>();
		InvokeRepeating ("addGold", 0f, goldRate);
	}
	
	// Update is called once per frame
	void Update () {
		if (minionsKilled > minionBaseVal) {
			gold = gold + (goldMultiplyer * (minionsKilled-minionBaseVal));
			minionBaseVal++;
		}
		float newConvert = goldPerSecond * 2;
		
		goldText[0].text = "GR: " + newConvert.ToString() + " GPS";
		goldText[1].text = "Bonus: " + goldMultiplyer.ToString() + "x";
		goldText[2].text = gold.ToString ();
		
	}
	
	void addGold(){
		float goldToAdd = goldMultiplyer * goldPerSecond; 
		gold = gold + goldToAdd;
		
	}
}
