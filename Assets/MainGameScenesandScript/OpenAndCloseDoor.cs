using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAndCloseDoor : MonoBehaviour {

  
    public GameObject door;

	// Use this for initialization
	void Start () {
        door.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {



		
	}


    private void OnTriggerEnter(Collider other)
    {


        if (other.tag == "Player")

        {

            door.SetActive(false);

        }


    }
}
