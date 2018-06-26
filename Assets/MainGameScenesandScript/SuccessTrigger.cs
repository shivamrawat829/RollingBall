using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuccessTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Flag")

        {
            Destroy(collision.gameObject);
            Debug.Log(collision.gameObject);
        }
    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "basest")

        {
            Destroy(other.gameObject);
            Debug.Log(other.gameObject);
        }

    }
}
