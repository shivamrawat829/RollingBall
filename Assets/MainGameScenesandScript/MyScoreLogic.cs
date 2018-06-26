using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MyScoreLogic : MonoBehaviour
{



  

    public Text MyCoinHighScore;


    private void Start()
    {


        string value = PlayerPrefs.GetInt("HighscoreCoin", 0).ToString();

      
        MyCoinHighScore.text ="High Score : " +value;
        Debug.Log("Value of high At stsrt" + value);
    }

    private void OnTriggerEnter(Collider other)
    {


        MyScoreTextScript.coinAmount += 1;

        Debug.Log(MyScoreTextScript.coinAmount);




        if (MyScoreTextScript.coinAmount > PlayerPrefs.GetInt("HighscoreCoin", 0))

        {

        
            PlayerPrefs.SetInt("HighscoreCoin", MyScoreTextScript.coinAmount);
          

            MyCoinHighScore.text = "High Score : " + MyScoreTextScript.coinAmount.ToString();
        }


    }
}

