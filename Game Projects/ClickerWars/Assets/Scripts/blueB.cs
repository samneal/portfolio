using UnityEngine;
using System.Collections;

public class blueB : MonoBehaviour {
	public float blueMinHealth;
	public float blueMinAttack;
	// Use this for initialization
	private float enemyAttack;
	
	public GameObject enemyMinion;
	void Start () {
		iTween.MoveTo(gameObject,iTween.Hash("path",iTweenPath.GetPath("blueBPath"),"time", spawnBlue.Instance.blueSpeed, "looptype", iTween.LoopType.none, "easetype", iTween.EaseType.linear,"movetopath", false));

	}
	
	// Update is called once per frame
	void Update () {
		blueMinHealth = spawnBlue.Instance.blueMinHealth;
		blueMinAttack = spawnBlue.Instance.blueMinAttack;

	}
	void OnCollisionEnter(Collision cc){
		
		if (cc.gameObject.tag == "redMinion") {
			enemyAttack = spawnRed.Instance.redMinAttack;
			blueMinHealth = blueMinHealth - enemyAttack;
			if(blueMinHealth <= 0){
				Destroy (gameObject);
				redGold.Instance.minionsKilled++;
			}
		}
		
		if (cc.gameObject.tag == "nexus") {
			Destroy (gameObject);
		}

		if (cc.gameObject.tag == "redWall") {


				Destroy (gameObject);

			}
		
		
	}
}
