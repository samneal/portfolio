using UnityEngine;
using System.Collections;

public class redY : MonoBehaviour {
	public float redMinHealth;
	public float redMinAttack;
	
	private float enemyAttack;
	public GameObject enemyMinion;
	// Use this for initialization
	void Start () {
		iTween.MoveTo(gameObject,iTween.Hash("path",iTweenPath.GetPath("redYPath"),"time", spawnRed.redYSpeed, "looptype", iTween.LoopType.none, "easetype", iTween.EaseType.linear,"movetopath", false));

	}
	
	// Update is called once per frame
	void Update () {
		redMinHealth = spawnRed.redMinHealth;
		redMinAttack = spawnRed.redMinAttack;
	}

	void OnCollisionEnter(Collision cc){
		
		if (cc.gameObject.tag == "blueMinion") {
			enemyAttack = spawnBlue.blueMinAttack;
			redMinHealth = redMinHealth - enemyAttack;
			if(redMinHealth <= 0){
				Destroy (gameObject);
				blueGold.minionsKilled++;
			}
		}
		
		if (cc.gameObject.tag == "nexus") {
			Destroy (gameObject);
		}
		if (cc.gameObject.tag == "blueWall") {

				Destroy (gameObject);


		}
		
	}
}
