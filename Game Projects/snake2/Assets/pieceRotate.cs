using UnityEngine;
using System.Collections;

public class pieceRotate : MonoBehaviour {
	public int scoreCheck = 0;
	public float speedInc = .0025f;
	public int bounceySpeed = 30;        //How long it takes the bounceys to complete their movement path
	// Use this for initialization
	float rotSpeed = WorldBehavior.rotSpeed;
	void Start () {
		int randPath = Random.Range (0, 4);
		if (randPath == 1) {
			Invoke ("movePath1", 2f);
		} else if (randPath == 2) {
			Invoke ("movePath2", 2f);
		} else if(randPath == 3){
			Invoke ("movePath3", 2f);
		}
	
	}
	public bool rotBoun = false;
	bool isBounRot = false;    //check if Bouncey is rotating
	// Update is called once per frame
	void Update () {

		if (Snake.score > scoreCheck) {
			if(rotSpeed <= 1.5f){
			rotSpeed += speedInc;
			}
			if(bounceySpeed > 18){
				bounceySpeed--;
			}
			scoreCheck++;
		}

		int randoBounce = WorldBehavior.randomVal;

		if (randoBounce % 100 == 0) {
			isBounRot = !isBounRot;

		}
		if (!isBounRot) {
			if (!rotBoun) {                       //Sets to Clockwise 
				Invoke ("Rotate", .1f);
				rotBoun = true;
			} else {
				//Invoke ("CounterRotate",14f);
				rotBoun = false;
			}
			
		} else {
			if (isBounRot) {                    //Sets to counter clockwise
				Invoke ("CounterRotate", .1f);
				rotBoun = true;
			} else {
				//Invoke ("CounterRotate",14f);
				rotBoun = false;
			}
			
		}

	}
	void Rotate(){
		transform.Rotate(0, 0, rotSpeed);
	}
	void CounterRotate(){
		transform.Rotate(0, 0, -rotSpeed);
	}

	void movePath1(){
		iTween.MoveTo(this.gameObject,iTween.Hash("path",iTweenPath.GetPath("bounceyPath1"),"time",bounceySpeed, "looptype", iTween.LoopType.pingPong, "easetype", iTween.EaseType.linear));
	}
	void movePath2(){
		iTween.MoveTo(this.gameObject,iTween.Hash("path",iTweenPath.GetPath("bounceyPath2"),"time",bounceySpeed, "looptype", iTween.LoopType.pingPong, "easetype", iTween.EaseType.linear));
	}
	void movePath3(){
		iTween.MoveTo(this.gameObject,iTween.Hash("path",iTweenPath.GetPath("bounceyPath3"),"time",bounceySpeed, "looptype", iTween.LoopType.pingPong, "easetype", iTween.EaseType.linear));
	} 


}
