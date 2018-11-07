using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public static class AdUtils  {

    public static void showSkipableAd(){

		while(!Advertisement.IsReady()){
			Debug.Log("waiting for ad");
		}
		Advertisement.Show("video");
		Debug.Log("ad showed");
	}
	public static void showAd(){

		while(!Advertisement.IsReady()){
			Debug.Log("waiting for ad");
		}
		Advertisement.Show("rewardedVideo");
		Debug.Log("ad showed");
	}
}
