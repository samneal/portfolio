using UnityEngine;
using System.Collections;

public class worldRules : MonoBehaviour {

	public static int p1ControlType = 0; //1-Controller, 2- Keyboard
	public static int p2ControlType = 0;
	private bool p1Ready = false;
	private bool p2Ready = false;

	public GameObject p1Go;
	public GameObject p2Go;
	public bool levelIsLoaded = false;
	// Use this for initialization
	void Start () {
		Debug.Log ("Level name:" + Application.loadedLevelName);
	}
	
	// Update is called once per frame
	void Update () {
		if (Application.loadedLevelName == "level1") {
			if (Input.GetButtonDown ("startButton")) {
				p1ControlType = 1;
			}
			if (Input.GetKeyDown ("z")) {
				p1ControlType = 2;
			}
			if (Input.GetButtonDown ("p2startButton")) {
				p2ControlType = 1;
			}
			if (Input.GetKeyDown ("m")) {
				p2ControlType = 2;
			}
		}else{
			if (Input.GetButtonDown ("xButton")) {
				p1ControlType = 1;
				p1Ready = true;

					p1Go.SetActive (p1Ready);
				
			}
			if (Input.GetKeyDown ("q")) {
				p1ControlType = 2;
				p1Ready = true;

					p1Go.SetActive (p1Ready);

			}

			if (Input.GetButtonDown ("p2xButton")) {
				p2ControlType = 1;
				p2Ready = true;

					p2Go.SetActive (p2Ready);
				
			}
			if (Input.GetKeyDown ("i")) {
				p2ControlType = 2;
				p2Ready = true;

					p2Go.SetActive (p2Ready);

			}
		}

	if (p1Ready && p2Ready) {
			Invoke ("loadLevelNow",1f);

		}
	}
	void loadLevelNow(){
		levelIsLoaded = true;
		Application.LoadLevel("level1");

	}
	
}
