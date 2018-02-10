using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Borders : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain")) {
    
            Application.LoadLevel(Application.loadedLevel);
 
        }
    }
}
