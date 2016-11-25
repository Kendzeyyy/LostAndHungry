using UnityEngine;
using System.Collections;


// kaikkien vihollisten yhteinen ohjain
// Author: Jenna Kopra

public class Enemies : MonoBehaviour {
	//public AudioClip impact;
	//AudioSource Hit;

	void OnCollisionEnter2D (Collision2D coll){												// törmäyksen metodi
		if (coll.gameObject.name == "ErikPlayer") {											// jos törmää erikin hahmoon
			//GetComponent<AudioSource>().PlayOneShot("Hit");
			Debug.Log ("Hit");																// kertoo consolessa "Hit"										
			Destroy (gameObject);															// tuhoaa vihollisen

		}
	}


	void Start () {																			// suorittaa ohjelman alkaessa
		

		GetComponent<Collider>();															// hakee colliderin
	}
	


	}


	
