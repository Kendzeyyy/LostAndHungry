using UnityEngine;
using System.Collections;

public class Enemies : MonoBehaviour {
	private GameObject enemy;

	void OnCollisionEnter2D (Collision2D coll){
		
		Debug.Log("Hit");
		Destroy(gameObject);

	}

	// Use this for initialization
	void Start () {
		
		enemy = GameObject.Find ("Enemy");
		GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void Update () {


	}

}
	
