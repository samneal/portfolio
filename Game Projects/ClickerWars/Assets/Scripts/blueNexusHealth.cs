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
	public GameObject minionB;
	
	private float enemyAttack;
	private float calcHealth;
	void Start () {
		currentHealth = blueHealth;
	}
	
	// Update is called once per frame
	void Update () {
		if (playerHealth <= 0) {
			

			Invoke ("redWins",0.5f);
		}
	
	}

	void OnCollisionEnter(Collision cc){
		if (cc.gameObject.tag == "redMinion") {
			
			enemyAttack = spawnRed.Instance.redMinAttack;
			playerHealth = playerHealth - enemyAttack;
			currentHealth -= enemyAttack;
			calcHealth = currentHealth / blueHealth;
			setHealthBar (calcHealth);
			
			
		}
	}
	
	public void setHealthBar(float myHealth){
		healthBar.transform.localScale = new Vector3 (myHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
	}
	void redWins(){
		Application.LoadLevel ("redWins");
	}
}
