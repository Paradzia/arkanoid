using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class premiumCoins : MonoBehaviour {

    public Text coinText;

    // Use this for initialization
    void Start () {
        coinText.text = PlayerPrefs.GetInt("premiumCoins").ToString();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
