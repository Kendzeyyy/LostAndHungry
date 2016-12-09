using UnityEngine;
using System.Collections;


// controller for all the enemies
// Author: Jenna Kopra

public class Enemies : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D coll){												// method for hitting
		if (coll.gameObject.name == "ErikPlayer") {											// hits erik
																																	
			Destroy (gameObject);															

		}
	}


	void Start () {																			
		

		GetComponent<Collider>();															// gets the collider
	}
	


	}


	
