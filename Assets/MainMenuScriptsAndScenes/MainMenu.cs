using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public GameObject loading_scren;
    public Slider slider;


    public void PlayGame()
    {

     


        StartCoroutine(LoadAsynchronously());

      //  SceneManager.LoadScene("RollerBall");

      

        MyScoreTextScript.coinAmount = 0;

    }

    IEnumerator LoadAsynchronously()
    {

        AsyncOperation operation = SceneManager.LoadSceneAsync("RollerBall");

        loading_scren.SetActive(true);
        while(!operation.isDone)


        {

            float progress = Mathf.Clamp01(operation.progress / .9f);
            Debug.Log(progress);
            slider.value = progress;
            yield return true;

        }

    }

    public void QuitGame()
    {

       
        Application.Quit();

    }



}
