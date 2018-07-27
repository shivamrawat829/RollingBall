using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour {


    public Image currenthealthbar;
    public Text ratioText;

    private float hitpoint = 100;
    private float maxHitpoint = 100;


    //r
    public GameObject panel1;

    public AudioSource Backgroundaudio1;
  


    public GameObject joypad1;
    public GameObject Boost1;

    public GameObject leftArrow1;
    public GameObject rightArrow1;
    public AudioSource fire1, fire2, fire3, fire4, fire5, fire6, fire7, fire8;





    public GameObject health1;

    // Use this for initialization
    private void Start () {


        UpdateHealthBar();

        
	}
	




    private void UpdateHealthBar()
    {

        float ratio = hitpoint / maxHitpoint;
        currenthealthbar.rectTransform.localScale = new Vector3(ratio, 1, 1);
        ratioText.text = (ratio * 100).ToString("0") + '%';

    }

    private void TakeDamage(float damage)
    {

        hitpoint -= damage;

        if(hitpoint < 0)

        {

            hitpoint = 0;
            Debug.Log("Dead");



          
            panel1.SetActive(true);
         

            joypad1.SetActive(false);
            Boost1.SetActive(false);

            leftArrow1.SetActive(false);

            rightArrow1.SetActive(false);

            health1.SetActive(false);

            fire1.Pause();
            fire2.Pause();
            fire3.Pause();
            fire4.Pause();
            fire5.Pause();
            fire6.Pause();
            fire7.Pause();
            fire8.Pause();
       
          
            Backgroundaudio1.Pause();




            

            Invoke("BuildMyScene", 3);


        }

        UpdateHealthBar();
    }

    private void BuildMyScene()
    {
        SceneManager.LoadScene("MainMenu");

    }

    private void HealDamage(float heal)
    {

        hitpoint += heal;

        if (hitpoint > maxHitpoint)

        

            hitpoint = maxHitpoint;
            Debug.Log("Dead");

        UpdateHealthBar();


    }

}
