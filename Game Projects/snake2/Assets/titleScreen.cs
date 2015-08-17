using UnityEngine;
using System.Collections;

public class titleScreen : MonoBehaviour {


	public Texture menuTexture;
	void OnGUI()
	{
		GUI.skin.label.fontSize = 30;
		int newScore = Snake.score;
		GUI.Label(new Rect(Screen.width/2-70,Screen.height/2-60, 400, 400), "Tap to go");


	}

	// Use this for initialization
	void Start () {
		// DontDestroyOnLoad(gameObject);     This breaks the game over screen, have to find new way of keeping score

	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.touchCount > 1) { 

			Application.LoadLevel("level1");
		} 
		if (Input.GetKeyDown(KeyCode.RightArrow)) {

			Application.LoadLevel("level1");
		}

	}
}
