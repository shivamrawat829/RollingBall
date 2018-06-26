using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioHealth : MonoBehaviour {


    public AudioSource healthAudio;

	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {


        transform.Rotate(0, 90 * Time.deltaTime, 0, 0);

    }

    private void OnTriggerStay(Collider col)
    {

        if (col.tag == "Player")
        {


            healthAudio.Play();

            


        }

    }


}
