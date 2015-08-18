using UnityEngine;
using System.Collections;

public class blueX : MonoBehaviour {
	public float blueMinHealth;
	public float blueMinAttack;
	// Use this for initialization
	private float enemyAttack;
	
	public GameObject enemyMinion;
	void Start () {
		iTween.MoveTo(gameObject,iTween.Hash("path",iTweenPath.GetPath("blueXPath"),"time", spawnBlue.blueSpeed, "looptype", iTween.LoopType.none, "easetype", iTween.EaseType.linear,"movetopath", false));

	}
	
	// Update is called once per frame
	void Update () {
		blueMinHealth = spawnBlue.blueMinHealth;
		blueMinAttack = spawnBlue.blueMinAttack;
	}
	void OnCollisionEnter(Collision cc){
		
		if (cc.gameObject.tag == "redMinion" ) {
			enemyAttack = spawnRed.redMinAttack;
			blueMinHealth = blueMinHealth - enemyAttack;
			if(blueMinHealth <= 0){
				Destroy (gameObject);
				redGold.minionsKilled++;
			}
		}

		if (cc.gameObject.tag == "redWall") {


				Destroy (gameObject);


		}
		
		if (cc.gameObject.tag == "nexus") {
			Destroy (gameObject);
		}
		
		
	}

}
