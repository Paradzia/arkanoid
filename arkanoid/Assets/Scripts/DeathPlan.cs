using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;


public class DeathPlan : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D other){
		GameManager gameManager = GameManager.getInstance();
		Destroy(other.gameObject);
		if(gameManager.lossCounter%5==0){
			AdUtils.showSkipableAd();
		}
		
		gameManager.objectGeneratorSwitch(); 
		gameManager.destroyObjects();
		gameManager.destroyPaddle();
		gameManager.createNewPaddle();
		gameManager.objectGeneratorSwitch(); 
	}
}
