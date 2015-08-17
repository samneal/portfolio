using UnityEngine;
using System.Collections;

public class bulletSticky : MonoBehaviour {


	// Use this for initialization
	void Start () {
		Destroy (gameObject,15f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision){

		if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Grenade") {
			GetComponent<Rigidbody> ().velocity = Vector3.zero;
		} else {
			GetComponent<Rigidbody>().velocity = Vector3.zero;
			GetComponent<Rigidbody> ().isKinematic = true;
		}



	}



}
