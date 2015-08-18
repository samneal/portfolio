using UnityEngine;
using System.Collections;

public class redHasHealth : MonoBehaviour {

	float hitPoints = spawnRed.Instance.redMinHealth;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void RecieveDamage(float amt){
		Debug.Log ("Recieve Damage: " + amt);
		
		hitPoints -= amt;
		if (hitPoints <= 0) {
			Die();
		}
	}
	void Die(){
		Destroy (gameObject);
	}

}
