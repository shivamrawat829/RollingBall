using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using GoogleMobileAds.Api;

public class TriggerGameOverScript : MonoBehaviour {

    public GameObject panel;
   
    public AudioSource Backgroundaudio;
    public AudioSource fall;


    public GameObject joypad;
    public GameObject Boost;

    public GameObject leftArrow;
    public GameObject rightArrow;



    public GameObject health;










    private void Start()
    {
        RequestInterstitialAds();
    }


    InterstitialAd interstitial;

    private void RequestInterstitialAds()
    {
       // string adID = "ca-app-pub-9352257827041167/8362484605";

        string adID = "ca-app-pub-3940256099942544/1033173712";

       

#if UNITY_ANDROID
        string adUnitId = adID;
#elif UNITY_IOS
        string adUnitId = adID;
#else
        string adUnitId = adID;
#endif

        // Initialize an InterstitialAd.
        interstitial = new InterstitialAd(adUnitId);

        //***Test***
       AdRequest request = new AdRequest.Builder()
       .AddTestDevice(AdRequest.TestDeviceSimulator)       // Simulator.
       .AddTestDevice("bd59533514066aa2")  // My test device.
       .Build();
       
        //***Production***
        //AdRequest request = new AdRequest.Builder().Build();

        //Register Ad Close Event
        

        // Load the interstitial with the request.
        interstitial.LoadAd(request);

        Debug.Log("AD LOADED XXX");
    }

    public void OnTriggerEnter(Collider other)
    {

       
        Debug.Log("Object Entered the trigger");

        //AdManager.Instance.showVideo();
        panel.SetActive(true);
        //  text.SetActive(true);

        joypad.SetActive(false);
        Boost.SetActive(false);

        leftArrow.SetActive(false);

        rightArrow.SetActive(false);


        health.SetActive(false);

        Backgroundaudio.Pause();

        fall.Play();




     

        Invoke("BUILDMYSCENE", 3);

            

           // SceneManager.LoadScene(scenenametoload);




    }

    

    void BUILDMYSCENE()
    {

        //  G1.GameOver();

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


        showInterstitialAd();
        SceneManager.LoadScene("MainMenu");

        //  SceneManager.LoadScene("RollerBall");


      //  panelMenu.SetActive(true);

    }


    public void showInterstitialAd()
    {
        //Show Ad
        if (interstitial.IsLoaded())
        {
            interstitial.Show();

            //Stop Sound
            //

            Debug.Log("SHOW AD XXX");
        }

    }
}
