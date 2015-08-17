using UnityEngine;
using System.Collections;

public class gameOver : MonoBehaviour {


	public Texture gameOverTexture;
	void OnGUI()
	{
		GUI.skin.label.fontSize = 30;
		int newScore = Snake.score;
		GUI.Label(new Rect(Screen.width/2 -70,Screen.height/2-50, 400, 400),"Your score: " + newScore.ToString ());
		GUI.Label(new Rect(Screen.width/2-70,Screen.height/2 - 20, 400, 400),"Tap to continue" );
		/*																
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), gameOverTexture);  //Creates a rectangle and specifies what do draw
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			Application.LoadLevel("level1");
		}
		*/

	}

	// Use this for initialization
	void Start () {
		// DontDestroyOnLoad(gameObject);     This breaks the game over screen, have to find new way of keeping score

	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.touchCount > 0) { 

			Application.LoadLevel("titleScreen");
		} 
		if (Input.GetKeyDown(KeyCode.RightArrow)) {

			Application.LoadLevel("titleScreen");
		}

	}
}
