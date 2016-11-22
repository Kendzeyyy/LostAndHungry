using UnityEngine;
using System.Collections;

public class Enemies : MonoBehaviour {
	private GameObject enemy;

	void OnCollisionEnter2D (Collision2D coll){
		if (coll.gameObject.name == "ErikPlayer") {
			Debug.Log ("Hit");
			Destroy (gameObject);

		}
	}

	// Use this for initialization
	void Start () {
		gameObject.tag = "Enemy";
		enemy = GameObject.Find ("Enemy");
		GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void Update () {


	}

}
	
