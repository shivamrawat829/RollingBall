using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CheckingSkyChangeTriggered : MonoBehaviour {


    public GameObject doortoopen;
    public Material s1;
    
	// Use this for initialization
	void Start () {

        doortoopen.SetActive(true);

    }
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")

        {

            doortoopen.SetActive(false);

            RenderSettings.skybox = s1;

             

           

        }
    }
}
