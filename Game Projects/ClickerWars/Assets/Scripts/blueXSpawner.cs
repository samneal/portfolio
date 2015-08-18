using UnityEngine;
using System.Collections;

public class blueXSpawner : MonoBehaviour {

	public Material activeMat;
	public Material cooldownMat;
	// Use this for initialization
	private bool isCoolDown = false;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (!spawnBlue.xIsReady) {
			gameObject.GetComponent<Renderer>().material = cooldownMat;
		} else {
			gameObject.GetComponent<Renderer> ().material = activeMat;
		}

	}
	void OnCollisionEnter(Collision cc){
		if (cc.gameObject.tag == "redMinion") {
			if(!isCoolDown){
				redGold.gold+= 100f;
				isCoolDown = true;
				Invoke("cooldownTimer",5f);
			}
		}
	}
	
	void cooldownTimer(){
		isCoolDown = false;
	}
}
