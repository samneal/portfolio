using UnityEngine;
using System.Collections;

public class blueB : MonoBehaviour {
	public float blueMinHealth = spawnBlue.blueMinHealth;
	public float blueMinAttack = spawnBlue.blueMinAttack;
	// Use this for initialization
	private float enemyAttack;
	
	public GameObject enemyMinion;
	void Start () {
		iTween.MoveTo(gameObject,iTween.Hash("path",iTweenPath.GetPath("blueBPath"),"time", spawnBlue.blueSpeed, "looptype", iTween.LoopType.none, "easetype", iTween.EaseType.linear,"movetopath", false));

	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter(Collision cc){
		
		if (cc.gameObject.tag == "redMinion") {
			enemyAttack = enemyMinion.GetComponent<redB>().redMinAttack;
			blueMinHealth = blueMinHealth - enemyAttack;
			if(blueMinHealth <= 0){
				Destroy (gameObject);
				redGold.minionsKilled++;
			}
		}
		
		if (cc.gameObject.tag == "nexus") {
			Destroy (gameObject);
		}

		if (cc.gameObject.tag == "redWall") {
			blueMinHealth = blueMinHealth - 1f;
			if(blueMinHealth <= 0){
				Destroy (gameObject);

			}
		}
		
	}
}
