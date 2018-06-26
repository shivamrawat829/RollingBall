using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerCoin : MonoBehaviour {
    

 

	// Use this for initialization
	void Start () {




      
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(0, 90 * Time.deltaTime, 0,0);
		
        
	}



    private void OnTriggerEnter(Collider other)
    {



       
        if (other.name == "RollerBall")
        {


            Destroy(gameObject);

            int newscore = other.GetComponent<BallCoinCollect>().points++;
      
        }


        
    }

  
    


}
