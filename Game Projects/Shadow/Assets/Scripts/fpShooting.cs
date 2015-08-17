using UnityEngine;
using System.Collections;

public class fpShooting : MonoBehaviour {
	public GameObject stickyBullet_Prefab;
	public float stickyBulletImpulse = 100f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		/* if(Input.GetMouseButtonDown(0)){
			Camera cam = Camera.main;

			GameObject theBullet = (GameObject)Instantiate (bullet_Prefab, cam.transform.position + cam.transform.forward , cam.transform.rotation);
			theBullet.GetComponent<Rigidbody>().AddForce(cam.transform.forward * bulletImpulse, ForceMode.Impulse);
		   }
		   */


		if(Input.GetMouseButtonDown(1)){
			Camera cam = Camera.main;
			
			GameObject theBullet2 = (GameObject)Instantiate (stickyBullet_Prefab, cam.transform.position + cam.transform.forward , cam.transform.rotation);
			theBullet2.GetComponent<Rigidbody>().AddForce(cam.transform.forward * stickyBulletImpulse, ForceMode.Impulse);
		}
	}
}
