using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour {

    public AudioSource fireAudio;

	// Use this for initialization
	void Start () {
       

        Enablemethod();

      

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   private void Enablemethod()

    {

        gameObject.SetActive(true);
        fireAudio.Play();

        Invoke("DisableTheObject", 2f);

        Debug.Log("EnableDisable Called");


    }



    private void DisableTheObject()

    {
        gameObject.SetActive(false);
        fireAudio.Pause();

        Invoke("Enablemethod", 1.5f);
        Debug.Log("Activate Called");

    }

}
