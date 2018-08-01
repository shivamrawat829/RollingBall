using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System;

public class GoogleUnityAds : MonoBehaviour {

    InterstitialAd interstitial;

    private BannerView bannerView;
   
    public void Start()
    {
        showBannerAd();
      
    }



    private void showBannerAd()
    {
      //  string adID = "ca-app-pub-9352257827041167/8304034036";


        // for checking
        string adID = "ca-app-pub-3940256099942544/6300978111";



        //***For Testing in the Device***
       AdRequest request = new AdRequest.Builder()
       .AddTestDevice(AdRequest.TestDeviceSimulator)       // Simulator.
       .AddTestDevice("bd59533514066aa2")  // My test device.
       .Build();

        //***For Production When Submit App***
       // AdRequest request = new AdRequest.Builder().Build();

       
        BannerView bannerAd = new BannerView(adID, AdSize.Banner, AdPosition.Bottom);
        bannerAd.LoadAd(request);
    }





    // Update is called once per frame
   


}
