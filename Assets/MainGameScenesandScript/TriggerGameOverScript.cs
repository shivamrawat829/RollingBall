using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TriggerGameOverScript : MonoBehaviour {

    public GameObject panel;
    public GameObject text;
    public AudioSource Backgroundaudio;
    public AudioSource fall;


    public GameObject joypad;
    public GameObject Boost;

    public GameObject leftArrow;
    public GameObject rightArrow;

    public GameObject panelMenu;









    private void Start()
    {
  
    }



   


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object Entered the trigger");


        panel.SetActive(true);
        //  text.SetActive(true);

        joypad.SetActive(false);
        Boost.SetActive(false);

        leftArrow.SetActive(false);

        rightArrow.SetActive(false);
        



        Backgroundaudio.Pause();

        fall.Play();

       




        Invoke("BUILDMYSCENE", 3);

            

           // SceneManager.LoadScene(scenenametoload);




    }

  
    

    void BUILDMYSCENE()
    {



        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

         SceneManager.LoadScene("MainMenu");

        //  SceneManager.LoadScene("RollerBall");


      //  panelMenu.SetActive(true);

    }
}
