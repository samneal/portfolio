using UnityEngine;
using System.Collections;

public class blueBSpawner : MonoBehaviour {

	public Material activeMat;
	public Material cooldownMat;
	private bool isCoolDown = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (!spawnBlue.Instance.bIsReady) {
			gameObject.GetComponent<Renderer>().material = cooldownMat;
		} else {
			gameObject.GetComponent<Renderer> ().material = activeMat;
		}

	}
	void OnCollisionEnter(Collision cc){
		if (cc.gameObject.tag == "redMinion") {
			if(!isCoolDown){
			redGold.Instance.gold+= 100f;
			isCoolDown = true;
				Invoke("cooldownTimer",5f);
			}
		}
	}

	void cooldownTimer(){
		isCoolDown = false;
	}
}
