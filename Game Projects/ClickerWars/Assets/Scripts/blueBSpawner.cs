using UnityEngine;
using System.Collections;

public class blueBSpawner : MonoBehaviour {

	public Material activeMat;
	public Material cooldownMat;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (!spawnBlue.bIsReady) {
			gameObject.GetComponent<Renderer>().material = cooldownMat;
		} else {
			gameObject.GetComponent<Renderer> ().material = activeMat;
		}

	}
}
