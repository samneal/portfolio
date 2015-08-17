using UnityEngine;
using System.Collections;

public class blueNexusHealth : MonoBehaviour {
	public float blueHealth = 100f;
	public float playerHealth = 100f;
	public float currentHealth = 0f;
	
	public GameObject healthBar;
	// Use this for initialization
	public GameObject minionX;
	public GameObject minionY;
	public GameObject minionZ;
	
	private float enemyAttack;
	private float calcHealth;
	void Start () {
		currentHealth = blueHealth;
	}
	
	// Update is called once per frame
	void Update () {
		if (playerHealth <= 0) {
			
			Destroy (gameObject);
		}
	
	}

	void OnCollisionEnter(Collision cc){
		if (cc.gameObject.tag == "redMinion") {
			if (cc.gameObject.name == "redX") {
				enemyAttack = minionX.GetComponent<redX> ().redMinAttack;
				playerHealth = playerHealth - enemyAttack;
				currentHealth -= enemyAttack;
				calcHealth = currentHealth / blueHealth;
				setHealthBar (calcHealth);
				
			} else if (cc.gameObject.name == "redY") {
				enemyAttack = minionY.GetComponent<redY> ().redMinAttack;
				playerHealth = playerHealth - enemyAttack;
				currentHealth -= enemyAttack;
				calcHealth = currentHealth / blueHealth;
				setHealthBar (calcHealth);
				
			} else if (cc.gameObject.name == "redB") {
				enemyAttack = minionY.GetComponent<redB> ().redMinAttack;
				playerHealth = playerHealth - enemyAttack;
				currentHealth -= enemyAttack;
				calcHealth = currentHealth / blueHealth;
				setHealthBar (calcHealth);
			}
			
			
			
			
		}
	}
	
	public void setHealthBar(float myHealth){
		healthBar.transform.localScale = new Vector3 (myHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
	}
}
