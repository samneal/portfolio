﻿using UnityEngine;
using System.Collections;

public class gameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("e") || Input.GetButtonDown ("p1bButton") || Input.GetButtonDown ("p2bButton")) {
			Application.LoadLevel ("titleScreen");
		}
	
	}
}
