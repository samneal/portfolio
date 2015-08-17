using UnityEngine;
using System.Collections;

public class redB : MonoBehaviour {
	public float redMinHealth = spawnRed.redMinHealth;
	public float redMinAttack = spawnRed.redMinAttack;
	
	private float enemyAttack;
	public GameObject enemyMinion;
	// Use this for initialization
	void Start () {
		iTween.MoveTo(gameObject,iTween.Hash("path",iTweenPath.GetPath("redBPath"),"time", spawnRed.redSpeed, "looptype", iTween.LoopType.none, "easetype", iTween.EaseType.linear,"movetopath", false));

	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter(Collision cc){
		
		if (cc.gameObject.tag == "blueMinion") {
			enemyAttack = enemyMinion.GetComponent<blueB> ().blueMinAttack;
			redMinHealth = redMinHealth - enemyAttack;
			if (redMinHealth <= 0) {
				Destroy (gameObject);
				blueGold.minionsKilled++;
			}
		}
		
		if (cc.gameObject.tag == "nexus") {
			Destroy (gameObject);
		}
		
		
	

		if (cc.gameObject.tag == "blueWall") {
			redMinHealth = redMinHealth - 1f;
			if (redMinHealth <= 0) {
				Destroy (gameObject);

			}
		}
	}
	
}
