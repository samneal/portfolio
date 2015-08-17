using UnityEngine;
using System.Collections;

public class boomGrenade : MonoBehaviour {
	public float grenadeGravity = .65f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	void Explode(){
		Destroy (gameObject);
	}

	void OnCollisionEnter(Collision collision){

		//Vector3 f = -(GetComponent<Rigidbody>().velocity * 0.5f);
		GetComponent<Rigidbody> ().velocity = (GetComponent<Rigidbody>().velocity - (GetComponent<Rigidbody>().velocity * grenadeGravity)) ;


			
		
	}

}
