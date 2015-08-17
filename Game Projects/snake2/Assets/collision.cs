using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D coll) {
		//Food?
		if (coll.name.StartsWith ("FoodPrefab")) {
			//Get longer in next Move call

		}else if(coll.name.StartsWith ("Tail")){
		
		}
		//Collided with Tail or Border
		else {
			//ToDo 'You Lose'' screen
			Application.LoadLevel ("gameOver");
		}
		
	}
}
