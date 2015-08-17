using UnityEngine;
using System.Collections;

public class redNexusHealth : MonoBehaviour {
	public float redHealth = 100f;
	public float playerHealth = 100f;
	public float currentHealth = 0f;

	public GameObject healthBar;

	public GameObject minionX;
	public GameObject minionY;
	public GameObject minionZ;

	private float enemyAttack;
	private float calcHealth;

	// Use this for initialization
	void Start () {
		currentHealth = redHealth;
			
	}
	
	// Update is called once per frame
	void Update () {


		if (playerHealth <= 0) {

			Destroy (gameObject);
		}
	
	}

	void OnCollisionEnter(Collision cc){
		if (cc.gameObject.tag == "blueMinion") {
			if(cc.gameObject.name == "blueX"){
			enemyAttack = minionX.GetComponent<blueX> ().blueMinAttack;
			playerHealth = playerHealth - enemyAttack;
			currentHealth -= enemyAttack;
			calcHealth = currentHealth / redHealth;
			setHealthBar (calcHealth);
			
			}else if(cc.gameObject.name == "blueY"){
				enemyAttack = minionY.GetComponent<blueY> ().blueMinAttack;
				playerHealth = playerHealth - enemyAttack;
				currentHealth -= enemyAttack;
				calcHealth = currentHealth / redHealth;
				setHealthBar (calcHealth);
			
			}else if(cc.gameObject.name == "blueB"){
				enemyAttack = minionY.GetComponent<blueB> ().blueMinAttack;
				playerHealth = playerHealth - enemyAttack;
				currentHealth -= enemyAttack;
				calcHealth = currentHealth / redHealth;
				setHealthBar (calcHealth);
			}


		

		}
	}


	public void setHealthBar(float myHealth){
		healthBar.transform.localScale = new Vector3 (myHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
	}
}
