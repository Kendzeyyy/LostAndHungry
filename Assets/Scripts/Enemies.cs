using UnityEngine;
using System.Collections;


public class Enemies : EnemySpawner {
	public AudioClip impact;
	AudioSource Hit;

	void OnCollisionEnter2D (Collision2D coll){
		if (coll.gameObject.name == "ErikPlayer") {
			//GetComponent<AudioSource>().PlayOneShot("Hit");
			Debug.Log ("Hit");
			Destroy (gameObject);

		}
	}

	// Use this for initialization
	void Start () {
		

		GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void Update () {


	}

	}


	
