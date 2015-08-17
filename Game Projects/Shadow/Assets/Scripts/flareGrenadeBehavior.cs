using UnityEngine;
using System.Collections;

public class flareGrenadeBehavior : MonoBehaviour {

	public float grenadeGravity = .45f;

	public float lifeSpan = 5.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame


	void Update () {

		lifeSpan -= Time.deltaTime;
		
		if (lifeSpan <= 0) {
			Explode();
		}
	}

	void Explode(){
		Destroy (gameObject);
	}
	void OnCollisionEnter(Collision collision){
		
		//Vector3 f = -(GetComponent<Rigidbody>().velocity * 0.5f);
		GetComponent<Rigidbody> ().velocity = (GetComponent<Rigidbody>().velocity - (GetComponent<Rigidbody>().velocity * grenadeGravity)) ;
		
		
		
		
	}


}
