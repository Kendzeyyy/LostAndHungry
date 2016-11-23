using UnityEngine;
using System.Collections;

public class MovingEnemy : Enemies {

	// Use this for initialization
	//private GameObject movingEnemy;
	// Use this for initialization
	void Start () {
		//movingEnemy = GameObject.Find ("MovingEnemy");
	}

	// Update is called once per frame
	void Update () {
		gameObject.transform.Translate (-0.1f, 0, 0);
	}
}
