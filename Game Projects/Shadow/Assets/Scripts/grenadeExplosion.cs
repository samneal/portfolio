using UnityEngine;
using System.Collections;

public class grenadeExplosion : MonoBehaviour {
	public GameObject explosionPart;
	public Vector3 detonationPoint;

	public float lifeSpan = 3.5f;

	public float damage = 200f;  //damage at center of explosion
	public float explosionRadius = 5f;

	// Use this for initialization
	void Start () {
		Invoke ("Detonate", lifeSpan);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Detonate(){
		Vector3 explosionPoint = transform.position;

		GameObject expl = Instantiate(explosionPart, transform.position, Quaternion.identity) as GameObject;
		Destroy (gameObject);

		Collider[] colliders = Physics.OverlapSphere (transform.position, explosionRadius);

		foreach (Collider c in colliders) {					//loop for arrays in Collider[]
			hasHealth h = c.GetComponent<hasHealth>();
			if(h != null){
				float dist = Vector3.Distance (explosionPoint, c.transform.position); //gets distance between two

				if(dist <= explosionRadius){
				Debug.Log ("Distance Between: " + dist);
				float damageRatio = 1f - (dist / explosionRadius);  //Takes some damage in radius of explosion, sets damage curve

				h.RecieveDamage(damage * damageRatio);
				}
			
			}
		}

	}
}
