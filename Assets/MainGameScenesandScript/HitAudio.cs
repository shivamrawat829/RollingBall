using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitAudio : MonoBehaviour {

    public AudioSource hitAudio;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerStay(Collider col)
    {

        if (col.tag == "Player")
        {




            hitAudio.Play();

        }

    }
}
