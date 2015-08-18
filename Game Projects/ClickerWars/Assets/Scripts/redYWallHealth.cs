using UnityEngine;
using System.Collections;

public class redYWallHealth : MonoBehaviour {
	public GameObject enemyMinion;
	private float enemyAttack;
	public float blockHealth = 30f;

	public float playerHealth = 30f;
	public float currentHealth = 0f;

	public GameObject healthBar;
	// Use this for initialization
	void Start () {
		currentHealth = blockHealth;
	}
	
	// Update is called once per frame
	void Update () {
		if (blockHealth <= 0) {
			Destroy (gameObject);
		}

	}
	void OnCollisionEnter(Collision cc){
		if (cc.gameObject.tag == "blueMinion") {
			enemyAttack = spawnBlue.blueMinAttack;
			blockHealth = blockHealth - enemyAttack;
			currentHealth -= enemyAttack;
			float calcHealth = currentHealth / playerHealth;
			setHealthBar(calcHealth);
			
		}
	}


	public void setHealthBar(float myHealth){
		healthBar.transform.localScale = new Vector3 (myHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
	}
}
