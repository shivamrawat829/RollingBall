﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {


    public Image currenthealthbar;
    public Text ratioText;

    private float hitpoint = 100;
    private float maxHitpoint = 100;

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

        }

        UpdateHealthBar();
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
