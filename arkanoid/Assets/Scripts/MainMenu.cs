﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayGame(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void QuitGame(){
		Debug.Log("quit click");
		Application.Quit();
	}

    public void ExtendPaddle()
    {
        int oldValue = PlayerPrefs.GetInt("premiumCoins");

        if (oldValue >= 5)
        {
            PlayerPrefs.SetInt("premiumCoins", oldValue - 5);
        }
        GameManager.instance.paddle.transform.localScale = new Vector3(1.5f, 1, 1);
    }
    public void NarrowPaddle()
    {
        int oldValue = PlayerPrefs.GetInt("premiumCoins");

        if (oldValue >= 5)
        {
            PlayerPrefs.SetInt("premiumCoins", oldValue - 5);
        }
        GameManager.instance.paddle.transform.localScale = new Vector3(0.5f, 1, 1);
    }

	
}




 
