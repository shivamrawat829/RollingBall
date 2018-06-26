using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCoinCollect : MonoBehaviour {


    public int points=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}


    private void OnGUI()
    {
        GUI.Label(new Rect(10,10,200,40), "Score : " + points);
    }
}
