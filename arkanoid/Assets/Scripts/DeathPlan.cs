using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;


public class DeathPlan : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D other){
		GameManager gameManager = GameManager.getInstance();
		Destroy(other.gameObject);
		AdUtils.showSkipableAd();
		gameManager.destroyObjects();
		gameManager.qwe();
	
	}
}
