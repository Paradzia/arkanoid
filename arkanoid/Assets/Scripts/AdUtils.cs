using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public static class AdUtils  {

    public static void showSkipableAd(){
		while(!Advertisement.IsReady()){
			Debug.Log("waiting for ad");
		}
		var options = new ShowOptions { resultCallback = HandleShowResult };
		Advertisement.Show("video", options);
		Debug.Log("ad showed");
	}
	public static void showAd(){

		while(!Advertisement.IsReady()){
			Debug.Log("waiting for ad");
		}
		var options = new ShowOptions { resultCallback = HandleShowResult };
		Advertisement.Show("rewardedVideo", options);
		Debug.Log("ad showed");
	}

	 private static void HandleShowResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                Debug.Log("The ad was successfully shown.");
                //TODO	nagrodzenie gracza w jakiś sposób
                break;
            case ShowResult.Skipped:
                Debug.Log("The ad was skipped before reaching the end.");
				//TODO pokazanie menu i gra od nowa 
                break;
            case ShowResult.Failed:
                Debug.LogError("The ad failed to be shown.");
				//TODO
                break;
        }
	}
}
