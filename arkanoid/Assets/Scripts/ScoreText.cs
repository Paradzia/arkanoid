using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {

	public Text scoreText;


	void Start () {
		scoreText.text = "0";
	}

	void Update(){
		scoreText.text = GameManager.instance.score.ToString();
	}
	
	

}
