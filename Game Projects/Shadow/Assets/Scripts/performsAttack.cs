using UnityEngine;
using System.Collections;

public class performsAttack : MonoBehaviour {
	public GameObject bullet_Prefab;
	public float bulletImpulse = 300f;

	public GameObject stickyBullet_Prefab;
	public float stickyBulletImpulse = 100f;

	public GameObject boomGrenade_Prefab;
	public float boomImpulse = 35f;

	public float gunRange = 100.0f;
	public GameObject debrisPrefab;
	public float damage = 50f;

	public GameObject flareGrenade_prefab;
	public float flareImpulse = 30f;

	private string[] grenadeType = new string[] {"flare","boom"}; 
	private int greNum = 0;
	//Machine gun code for weapon cooldown
	// public float cooldown = 0.1f;
	//float cooldownRemaining = 0;
	//cooldownRemaining -= Time.deltaTime;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("t")) {
			if(greNum == 0){
				greNum++;
			}else{
				greNum--; 
			}
		}

		if (Input.GetMouseButtonDown (0)) {
			Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
			RaycastHit hitInfo;  //Passing as output parameter

			//Makes bullet object


			if(Physics.Raycast (ray, out hitInfo, gunRange))      // returns t/f
			{
				Vector3 hitPoint = hitInfo.point;
				GameObject go = hitInfo.collider.gameObject;
				Debug.Log ("Hit Object:" + go.name);  //will tell us what we hit
				Debug.Log ("Hit Point:" + hitPoint);   //will tell us where we hit

				hasHealth h = go.GetComponent<hasHealth>();

				if(h != null){
					h.RecieveDamage (damage);
				}

				if(debrisPrefab != null){
 					Instantiate (debrisPrefab, hitPoint, Quaternion.identity); 

				}
								
			}
			Camera cam = Camera.main;
			GameObject theBullet = (GameObject)Instantiate (bullet_Prefab, cam.transform.position + cam.transform.forward , cam.transform.rotation);
			theBullet.GetComponent<Rigidbody>().AddForce(cam.transform.forward * bulletImpulse, ForceMode.Impulse);


		}
		if(Input.GetMouseButtonDown(1)){
			Camera cam = Camera.main;
			GameObject stickyBullet = (GameObject)Instantiate (stickyBullet_Prefab, cam.transform.position + cam.transform.forward , cam.transform.rotation);
			stickyBullet.GetComponent<Rigidbody>().AddForce(cam.transform.forward * stickyBulletImpulse, ForceMode.Impulse);




		
		}

		if (Input.GetKeyDown ("g")) {

			throwGrenade (greNum);

		}

			
	}

	void throwGrenade(int dex){
		Camera cam = Camera.main;

		if (grenadeType [dex] == "flare") {
			GameObject flareGrenade = (GameObject)Instantiate (flareGrenade_prefab, cam.transform.position, cam.transform.rotation);
			flareGrenade.GetComponent<Rigidbody> ().AddForce (cam.transform.forward * flareImpulse, ForceMode.Impulse);
		}
		
		if(grenadeType[dex] == "boom"){
			GameObject boomGrenade = (GameObject)Instantiate (boomGrenade_Prefab, cam.transform.position + cam.transform.forward , cam.transform.rotation);
			boomGrenade.GetComponent<Rigidbody>().AddForce(cam.transform.forward * boomImpulse, ForceMode.Impulse);
		}
	}




}
